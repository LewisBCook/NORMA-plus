#region Common Public License Copyright Notice
/**************************************************************************\
* Neumont Object-Role Modeling Architect for Visual Studio                 *
*                                                                          *
* Copyright � Neumont University. All rights reserved.                     *
*                                                                          *
* The use and distribution terms for this software are covered by the      *
* Common Public License 1.0 (http://opensource.org/licenses/cpl) which     *
* can be found in the file CPL.txt at the root of this distribution.       *
* By using this software in any fashion, you are agreeing to be bound by   *
* the terms of this license.                                               *
*                                                                          *
* You must not remove this notice, or any other, from this software.       *
\**************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.Modeling;

namespace Neumont.Tools.Modeling.Shell.DynamicSurveyTreeGrid
{
	/// <summary>
	/// survey question ui support enum
	/// </summary>
	[Flags]
	public enum SurveyQuestionUISupport
	{
		/// <summary>
		/// If nothing is supported by question
		/// </summary>
		None = 0,
		/// <summary>
		/// If sorting is supported by question
		/// </summary>
		Sorting = 1,
		/// <summary>
		/// If grouping is supported, defaults to sorting supported too
		/// </summary>
		Grouping = 2,
		/// <summary>
		/// If question supports glyphs
		/// </summary>
		Glyph = 4,
		/// <summary>
		/// If overlay is supported by question
		/// </summary>
		Overlay = 8,
	}
	/// <summary>
	/// question list of all questions returned by the doc data
	/// </summary>
	public class Survey
	{
		private readonly List<SurveyQuestion> myQuestions;
		private int totalShift;
		/// <summary>
		/// public constructor
		/// </summary>
		/// <param name="questionProviderList">enumerable object of ISurveyQuestion providers</param>
		public Survey(IEnumerable<ISurveyQuestionProvider> questionProviderList)
		{
			if (questionProviderList == null)
			{
				throw new ArgumentNullException("questionProviderList");
			}
			myQuestions = new List<SurveyQuestion>();
			LoadQuestions(questionProviderList);
		}
		#region ProcessNodes
		/// <summary>
		/// cycles through all SampleDataElementNodes in the list and creates their node data based on the answer to this survey's questions
		/// </summary>
		/// <param name="nodeList"></param>
		/// <returns></returns>
		public IList<SampleDataElementNode> ProcessNodes(IList<SampleDataElementNode> nodeList)
		{
			IList<SampleDataElementNode> retList = nodeList;
			for (int i = 0; i < nodeList.Count; ++i)
			{
				SampleDataElementNode currentNode = retList[i];
				currentNode.NodeData = 0;
				for (int j = 0; j < myQuestions.Count; ++j)
				{
					SurveyQuestion currentQuestion = myQuestions[j];
					int currentAnswer = currentQuestion.Question.AskQuestion(currentNode.Element);
					currentNode.NodeData |= (currentAnswer << currentQuestion.Shift) & currentQuestion.Mask;
				}
				retList[i] = currentNode;
			}
			return retList;
		}
		#endregion //ProcessNodes
		#region LoadQuestions
		private void LoadQuestions(IEnumerable<ISurveyQuestionProvider> providers)
		{
			foreach (ISurveyQuestionProvider provider in providers)
			{
				ISurveyQuestionTypeInfo[] currentQuestions = provider.GetSurveyQuestionTypeInfo();
				for (int i = 0; i < currentQuestions.Length; ++i)
				{
					SurveyQuestion currentQuestion = new SurveyQuestion(currentQuestions[i]);
					currentQuestion.Shift = totalShift;
					currentQuestion.Mask = GenerateMask(currentQuestion.BitCount, currentQuestion.Shift);
					currentQuestion.QuestionList = this;
					totalShift += currentQuestion.BitCount;
					myQuestions.Add(currentQuestion);
				}
			}
		}
		#endregion
		#region indexers
		/// <summary>
		/// indexer for question list
		/// </summary>
		/// <param name="i">int index of questions to be returned</param>
		/// <returns>survey question at the location</returns>
		public SurveyQuestion this[int i]
		{
			get
			{
				return myQuestions[i];
			}
		}
		/// <summary>
		/// indexer for question list
		/// </summary>
		/// <param name="question">type of question to retrieve</param>
		/// <returns>survey question of matching type</returns>
		public SurveyQuestion this[Type question]
		{
			get 
			{
				for (int i = 0; i < myQuestions.Count; ++i)
				{
					SurveyQuestion currentQuestion = myQuestions[i];
					if (currentQuestion.Question.QuestionType == question)
					{
						return currentQuestion;
					}
				}
				return null;
			}
		}
		#endregion
		/// <summary>
		/// number of questions in the survey
		/// </summary>
		public int Count
		{
			get
			{
				return myQuestions.Count;
			}
		}
		/// <summary>
		/// returns index of question type passed in
		/// </summary>
		public int GetIndex(Type question)
		{
			for (int i = 0; i < myQuestions.Count; ++i)
			{
				if (question == myQuestions[i].Question.QuestionType) 
				{ 
					return i;
				}
			}
			return -1;
		}
		private static int GenerateMask(int bitCount, int shift)
		{
			return ((1 << bitCount) - 1) << shift;
		}
	}
	/// <summary>
	/// wrapper for ISurveyQeustionTypeInfo, holds some metadata about the question
	/// </summary>
	public sealed class SurveyQuestion
	{
		private readonly ISurveyQuestionTypeInfo myQuestion;
		private readonly string[] myHeaders;
		#region MetaData and local members
		private int shift;
		/// <summary>
		/// the total bitcount shift that this answer should have in all SampleDataElementNodes node data
		/// </summary>
		public int Shift
		{
			get
			{
				return shift;
			}
			set
			{
				shift = value;
			}
		}
		private int mask;
		/// <summary>
		/// integer mask, the not applicable answer to this question shifted by the total shift for the survey this is in
		/// </summary>
		public int Mask
		{
			get
			{
				return mask;
			}
			set
			{
				mask = value;
			}
		}

		private SurveyQuestionUISupport uiSupport;
		/// <summary>
		/// ui support info associated with this question
		/// </summary>
		public SurveyQuestionUISupport UISupport
		{
			get
			{
				return uiSupport;
			}
			set
			{
				uiSupport = value;
			}
		}
		private Survey questionList;
		/// <summary>
		/// the survey that this question is held in
		/// </summary>
		public Survey QuestionList
		{
			get 
			{
				return this.questionList;
			}
			set
			{
				questionList = value;
			}
		}
		#endregion //MetaData and local members
		/// <summary>
		/// returns the wrapped ISurveyQuestionTypeInfo
		/// </summary>
		public ISurveyQuestionTypeInfo Question
		{
			get
			{
				return myQuestion;
			}
		}
		/// <summary>
		/// number of answers to this question, doesn't include not applicable.
		/// </summary>
		public int CategoryCount
		{
			get
			{
				return myHeaders.Length;
			}
		}
		/// <summary>
		/// number of bytes needed to store all answers to this question, does allot necessary space for not applicable
		/// </summary>
		public int BitCount
		{
			get
			{
				int itemCount = myHeaders.Length + 1;
				int bitCount = 0;
				while (itemCount > 0)
				{
					itemCount >>= 1;
					bitCount++;
				}
				return bitCount;
			}
		}

		/// <summary>
		/// returns the header 
		/// </summary>
		/// <param name="answer"></param>
		/// <returns></returns>
		public string CategoryHeader(int answer)
		{
			if (answer < 0 || answer > myHeaders.Length - 1)
			{
				// UNDONE: Localize this.
				return "Not Applicable";
			}
			return myHeaders[answer];
		}
		/// <summary>
		/// returns the answer value to this question in the integer node data passed in
		/// </summary>
		/// <param name="answerData">node data containing an answer to this question</param>
		/// <returns>the integer value of the answer to this question</returns>
		public int ExtractAnswer(int answerData)
		{
			return (answerData & Mask) >> Shift;
		}
		/// <summary>
		/// public constructor
		/// </summary>
		/// <param name="question">the qeustion to be wrapped by this class</param>
		public SurveyQuestion(ISurveyQuestionTypeInfo question)
		{
			if (question == null)
			{
				throw new ArgumentNullException("question");
			}
			myQuestion = question;
			// UNDONE: This needs to be changed to get the localized enum names
			myHeaders = Enum.GetNames(question.QuestionType);
		}
	}
}