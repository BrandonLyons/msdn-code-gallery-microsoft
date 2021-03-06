﻿//******************************************************************
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// This code is licensed under the Visual Studio SDK license terms.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//******************************************************************
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
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Company.SlideShowDesigner
{
	/// <summary>
	/// Double-derived base class for DomainClass PhotoShape
	/// </summary>
	[DslDesign::DisplayNameResource("Company.SlideShowDesigner.PhotoShape.DisplayName", typeof(global::Company.SlideShowDesigner.SlideShowDesignerDomainModel), "PhotoStudio.SlideShowDesigner.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Company.SlideShowDesigner.PhotoShape.Description", typeof(global::Company.SlideShowDesigner.SlideShowDesignerDomainModel), "PhotoStudio.SlideShowDesigner.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Company.SlideShowDesigner.SlideShowDesignerDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("31dc9b1d-5cd4-4b31-a156-492967cd9c33")]
	public abstract partial class PhotoShapeBase : DslDiagrams::ImageShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with PhotoShape.
		/// </summary>
		public static DslDiagrams::Decorator FindPhotoShapeDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		
		/// <summary>
		/// Shape instance initialization.
		/// </summary>
		public override void OnInitialize()
		{
			base.OnInitialize();
			
			// Create host shapes for outer decorators.
			foreach(DslDiagrams::Decorator decorator in this.Decorators)
			{
				if(decorator.RequiresHost)
				{
					decorator.ConfigureHostShape(this);
				}
			}
			
		}
		#endregion
		#region Shape size
		#endregion
		#region Shape styles
		#endregion
		#region Decorators
		/// <summary>
		/// Initialize the collection of shape fields associated with this shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
		}
		
		/// <summary>
		/// Initialize the collection of decorators associated with this shape type.  This method also
		/// creates shape fields for outer decorators, because these are not part of the shape fields collection
		/// associated with the shape, so they must be created here rather than in InitializeShapeFields.
		/// </summary>
		protected override void InitializeDecorators(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields, global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators)
		{
			base.InitializeDecorators(shapeFields, decorators);
			
			DslDiagrams::TextField field1 = new DslDiagrams::TextField("NameDecorator");
			field1.DefaultText = global::Company.SlideShowDesigner.SlideShowDesignerDomainModel.SingletonResourceManager.GetString("PhotoShapeNameDecoratorDefaultText");
			field1.DefaultFocusable = true;
			field1.DefaultAutoSize = true;
			field1.AnchoringBehavior.MinimumHeightInLines = 1;
			field1.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field1.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			DslDiagrams::Decorator decorator1 = new DslDiagrams::ShapeDecorator(field1, DslDiagrams::ShapeDecoratorPosition.OuterBottomCenter, DslDiagrams::PointD.Empty);
			decorators.Add(decorator1);
				
		}
		
		/// <summary>
		/// Ensure outer decorators are placed appropriately.  This is called during view fixup,
		/// after the shape has been associated with the model element.
		/// </summary>
		public override void OnBoundsFixup(DslDiagrams::BoundsFixupState fixupState, int iteration, bool createdDuringViewFixup)
		{
			base.OnBoundsFixup(fixupState, iteration, createdDuringViewFixup);
			
			if(iteration == 0)
			{
				foreach(DslDiagrams::Decorator decorator in this.Decorators)
				{
					if(decorator.RequiresHost)
					{
						decorator.RepositionHostShape(decorator.GetHostShape(this));
					}
				}
			}
		}
		#endregion
		/// <summary>
		/// Provide the specific Image for this Shape class
		/// </summary>
		protected override global::System.Drawing.Image Image
		{
			get
			{
				global::System.Resources.ResourceManager resourceManager = global::Company.SlideShowDesigner.SlideShowDesignerDomainModel.SingletonResourceManager;
				return DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("PhotoShapeImage"));
			}
		}
		#region Constructors, domain class Id
	
		/// <summary>
		/// PhotoShape domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x31dc9b1d, 0x5cd4, 0x4b31, 0xa1, 0x56, 0x49, 0x29, 0x67, 0xcd, 0x9c, 0x33);
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		protected PhotoShapeBase(DslModeling::Partition partition, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region ImagePath domain property code
		
		/// <summary>
		/// ImagePath domain property Id.
		/// </summary>
		public static readonly global::System.Guid ImagePathDomainPropertyId = new global::System.Guid(0x113f948a, 0x15d8, 0x478c, 0x9e, 0x73, 0xb3, 0x2b, 0x5b, 0x00, 0x19, 0x9d);
		
		/// <summary>
		/// Storage for ImagePath
		/// </summary>
		private global::System.String imagePathPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of ImagePath domain property.
		/// Description for Company.SlideShowDesigner.PhotoShape.Image Path
		/// </summary>
		[DslDesign::DisplayNameResource("Company.SlideShowDesigner.PhotoShape/ImagePath.DisplayName", typeof(global::Company.SlideShowDesigner.SlideShowDesignerDomainModel), "PhotoStudio.SlideShowDesigner.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Company.SlideShowDesigner.PhotoShape/ImagePath.Description", typeof(global::Company.SlideShowDesigner.SlideShowDesignerDomainModel), "PhotoStudio.SlideShowDesigner.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("113f948a-15d8-478c-9e73-b32b5b00199d")]
		public global::System.String ImagePath
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return imagePathPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ImagePathPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the PhotoShape.ImagePath domain property.
		/// </summary>
		internal sealed partial class ImagePathPropertyHandler : DslModeling::DomainPropertyValueHandler<PhotoShapeBase, global::System.String>
		{
			private ImagePathPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the PhotoShape.ImagePath domain property value handler.
			/// </summary>
			public static readonly ImagePathPropertyHandler Instance = new ImagePathPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the PhotoShape.ImagePath domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ImagePathDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(PhotoShapeBase element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.imagePathPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(PhotoShapeBase element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.imagePathPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
	/// <summary>
	/// DomainClass PhotoShape
	/// Description for Company.SlideShowDesigner.PhotoShape
	/// </summary>
	[global::System.CLSCompliant(true)]
			
	public partial class PhotoShape : PhotoShapeBase
	{
		#region Constructors
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public PhotoShape(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public PhotoShape(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}

