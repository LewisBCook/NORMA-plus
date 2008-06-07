﻿#region Common Public License Copyright Notice
/**************************************************************************\
* Neumont Object-Role Modeling Architect for Visual Studio                 *
*                                                                          *
* Copyright © Neumont University. All rights reserved.                     *
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
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace Neumont.Tools.ORMAbstractionToBarkerERBridge
{
	/// <summary>
	/// DomainClass MappingBarkerModel
	/// </summary>
	[DslDesign::DisplayNameResource("Neumont.Tools.ORMAbstractionToBarkerERBridge.MappingBarkerModel.DisplayName", typeof(global::Neumont.Tools.ORMAbstractionToBarkerERBridge.ORMAbstractionToBarkerERBridgeDomainModel), "Neumont.Tools.ORMAbstractionToBarkerERBridge.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Neumont.Tools.ORMAbstractionToBarkerERBridge.MappingBarkerModel.Description", typeof(global::Neumont.Tools.ORMAbstractionToBarkerERBridge.ORMAbstractionToBarkerERBridgeDomainModel), "Neumont.Tools.ORMAbstractionToBarkerERBridge.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("1eaa1877-f749-465c-ab97-9c64f9582bf8")]
	public partial class MappingBarkerModel : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// MappingBarkerModel domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x1eaa1877, 0xf749, 0x465c, 0xab, 0x97, 0x9c, 0x64, 0xf9, 0x58, 0x2b, 0xf8);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MappingBarkerModel(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartition : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MappingBarkerModel(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace Neumont.Tools.ORMAbstractionToBarkerERBridge
{
	/// <summary>
	/// DomainClass BarkerERModelGenerationSetting
	/// </summary>
	[DslDesign::DisplayNameResource("Neumont.Tools.ORMAbstractionToBarkerERBridge.BarkerERModelGenerationSetting.DisplayName", typeof(global::Neumont.Tools.ORMAbstractionToBarkerERBridge.ORMAbstractionToBarkerERBridgeDomainModel), "Neumont.Tools.ORMAbstractionToBarkerERBridge.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Neumont.Tools.ORMAbstractionToBarkerERBridge.BarkerERModelGenerationSetting.Description", typeof(global::Neumont.Tools.ORMAbstractionToBarkerERBridge.ORMAbstractionToBarkerERBridgeDomainModel), "Neumont.Tools.ORMAbstractionToBarkerERBridge.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("77b26a43-49cf-47ce-bdcc-44fd78f9096f")]
	public partial class BarkerERModelGenerationSetting : global::Neumont.Tools.ORM.ObjectModel.GenerationSetting
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// BarkerERModelGenerationSetting domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x77b26a43, 0x49cf, 0x47ce, 0xbd, 0xcc, 0x44, 0xfd, 0x78, 0xf9, 0x09, 0x6f);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public BarkerERModelGenerationSetting(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartition : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public BarkerERModelGenerationSetting(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region CoreAlgorithmVersion domain property code
		
		/// <summary>
		/// CoreAlgorithmVersion domain property Id.
		/// </summary>
		public static readonly global::System.Guid CoreAlgorithmVersionDomainPropertyId = new global::System.Guid(0xde3d9138, 0x4e38, 0x427b, 0xba, 0x66, 0xdf, 0x7b, 0x3c, 0xcd, 0xc4, 0xfa);
		
		/// <summary>
		/// Storage for CoreAlgorithmVersion
		/// </summary>
		private global::System.String coreAlgorithmVersionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of CoreAlgorithmVersion domain property.
		/// Description for
		/// Neumont.Tools.ORMAbstractionToBarkerERBridge.BarkerERModelGenerationSetting.Depth
		/// </summary>
		[DslDesign::DisplayNameResource("Neumont.Tools.ORMAbstractionToBarkerERBridge.BarkerERModelGenerationSetting/CoreAlgorithmVersion.DisplayName", typeof(global::Neumont.Tools.ORMAbstractionToBarkerERBridge.ORMAbstractionToBarkerERBridgeDomainModel), "Neumont.Tools.ORMAbstractionToBarkerERBridge.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Neumont.Tools.ORMAbstractionToBarkerERBridge.BarkerERModelGenerationSetting/CoreAlgorithmVersion.Description", typeof(global::Neumont.Tools.ORMAbstractionToBarkerERBridge.ORMAbstractionToBarkerERBridgeDomainModel), "Neumont.Tools.ORMAbstractionToBarkerERBridge.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("de3d9138-4e38-427b-ba66-df7b3ccdc4fa")]
		public global::System.String CoreAlgorithmVersion
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return coreAlgorithmVersionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CoreAlgorithmVersionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the BarkerERModelGenerationSetting.CoreAlgorithmVersion domain property.
		/// </summary>
		internal sealed partial class CoreAlgorithmVersionPropertyHandler : DslModeling::DomainPropertyValueHandler<BarkerERModelGenerationSetting, global::System.String>
		{
			private CoreAlgorithmVersionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the BarkerERModelGenerationSetting.CoreAlgorithmVersion domain property value handler.
			/// </summary>
			public static readonly CoreAlgorithmVersionPropertyHandler Instance = new CoreAlgorithmVersionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the BarkerERModelGenerationSetting.CoreAlgorithmVersion domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CoreAlgorithmVersionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(BarkerERModelGenerationSetting element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.coreAlgorithmVersionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(BarkerERModelGenerationSetting element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.coreAlgorithmVersionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region NameAlgorithmVersion domain property code
		
		/// <summary>
		/// NameAlgorithmVersion domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameAlgorithmVersionDomainPropertyId = new global::System.Guid(0x803570cd, 0xa276, 0x4f30, 0x9b, 0xc6, 0x70, 0xaa, 0x92, 0x3b, 0x7f, 0x97);
		
		/// <summary>
		/// Storage for NameAlgorithmVersion
		/// </summary>
		private global::System.String nameAlgorithmVersionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of NameAlgorithmVersion domain property.
		/// Description for
		/// Neumont.Tools.ORMAbstractionToBarkerERBridge.BarkerERModelGenerationSetting.Depth
		/// </summary>
		[DslDesign::DisplayNameResource("Neumont.Tools.ORMAbstractionToBarkerERBridge.BarkerERModelGenerationSetting/NameAlgorithmVersion.DisplayName", typeof(global::Neumont.Tools.ORMAbstractionToBarkerERBridge.ORMAbstractionToBarkerERBridgeDomainModel), "Neumont.Tools.ORMAbstractionToBarkerERBridge.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Neumont.Tools.ORMAbstractionToBarkerERBridge.BarkerERModelGenerationSetting/NameAlgorithmVersion.Description", typeof(global::Neumont.Tools.ORMAbstractionToBarkerERBridge.ORMAbstractionToBarkerERBridgeDomainModel), "Neumont.Tools.ORMAbstractionToBarkerERBridge.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("803570cd-a276-4f30-9bc6-70aa923b7f97")]
		public global::System.String NameAlgorithmVersion
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return nameAlgorithmVersionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NameAlgorithmVersionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the BarkerERModelGenerationSetting.NameAlgorithmVersion domain property.
		/// </summary>
		internal sealed partial class NameAlgorithmVersionPropertyHandler : DslModeling::DomainPropertyValueHandler<BarkerERModelGenerationSetting, global::System.String>
		{
			private NameAlgorithmVersionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the BarkerERModelGenerationSetting.NameAlgorithmVersion domain property value handler.
			/// </summary>
			public static readonly NameAlgorithmVersionPropertyHandler Instance = new NameAlgorithmVersionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the BarkerERModelGenerationSetting.NameAlgorithmVersion domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameAlgorithmVersionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(BarkerERModelGenerationSetting element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.nameAlgorithmVersionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(BarkerERModelGenerationSetting element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.nameAlgorithmVersionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region GeneratedBarkerERModel opposite domain role accessor
		/// <summary>
		/// Gets or sets GeneratedBarkerERModel.
		/// Description for
		/// Neumont.Tools.ORMAbstractionToBarkerERBridge.GenerationSettingTargetsBarkerERModel.GenerationSetting
		/// </summary>
		public virtual global::Neumont.Tools.EntityRelationshipModels.Barker.BarkerErModel GeneratedBarkerERModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Neumont.Tools.ORMAbstractionToBarkerERBridge.GenerationSettingTargetsBarkerERModel.GenerationSettingDomainRoleId) as global::Neumont.Tools.EntityRelationshipModels.Barker.BarkerErModel;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::ModelElement existingSource;
				if (null != value &&
					null != (existingSource = DslModeling::DomainRoleInfo.GetLinkedElement(value, global::Neumont.Tools.ORMAbstractionToBarkerERBridge.GenerationSettingTargetsBarkerERModel.GeneratedBarkerERModelDomainRoleId)))
				{
					if (existingSource != value)
					{
						DslModeling::DomainRoleInfo.SetLinkedElement(value, global::Neumont.Tools.ORMAbstractionToBarkerERBridge.GenerationSettingTargetsBarkerERModel.GeneratedBarkerERModelDomainRoleId, this);
					}
				}
				else
				{
					DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Neumont.Tools.ORMAbstractionToBarkerERBridge.GenerationSettingTargetsBarkerERModel.GenerationSettingDomainRoleId, value);
				}
			}
		}
		#endregion
	}
}