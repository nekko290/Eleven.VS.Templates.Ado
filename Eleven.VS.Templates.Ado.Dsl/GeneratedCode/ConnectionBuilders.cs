﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Eleven.VS.Templates.Ado.Dsl
{
	/// <summary>
	/// ConnectionBuilder class to provide logic for constructing connections between elements.
	/// </summary>
	public static partial class DomainEntityReferencesTargetDomainEntitiesBuilder
	{
		#region Accept Connection Methods
		/// <summary>
		/// Test whether a given model element is acceptable to this ConnectionBuilder as the source of a connection.
		/// </summary>
		/// <param name="candidate">The model element to test.</param>
		/// <returns>Whether the element can be used as the source of a connection.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		public static bool CanAcceptSource(DslModeling::ModelElement candidate)
		{
			if (candidate == null) return false;
			else if (candidate is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
			{ 
				return true;
			}
			else
				return false;
		}

		/// <summary>
		/// Test whether a given model element is acceptable to this ConnectionBuilder as the target of a connection.
		/// </summary>
		/// <param name="candidate">The model element to test.</param>
		/// <returns>Whether the element can be used as the target of a connection.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		public static bool CanAcceptTarget(DslModeling::ModelElement candidate)
		{
			if (candidate == null) return false;
			else if (candidate is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
			{ 
				return true;
			}
			else
				return false;
		}
		
		/// <summary>
		/// Test whether a given pair of model elements are acceptable to this ConnectionBuilder as the source and target of a connection
		/// </summary>
		/// <param name="candidateSource">The model element to test as a source</param>
		/// <param name="candidateTarget">The model element to test as a target</param>
		/// <returns>Whether the elements can be used as the source and target of a connection</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Generated code.")]
		public static bool CanAcceptSourceAndTarget(DslModeling::ModelElement candidateSource, DslModeling::ModelElement candidateTarget)
		{
			// Accepts null, null; source, null; source, target but NOT null, target
			if (candidateSource == null)
			{
				if (candidateTarget != null)
				{
					throw new global::System.ArgumentNullException("candidateSource");
				}
				else // Both null
				{
					return false;
				}
			}
			bool acceptSource = CanAcceptSource(candidateSource);
			// If the source wasn't accepted then there's no point checking targets.
			// If there is no target then the source controls the accept.
			if (!acceptSource || candidateTarget == null)
			{
				return acceptSource;
			}
			else // Check combinations
			{
				if (candidateSource is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
				{
					if (candidateTarget is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
					{
						return true;
					}
				}
				
			}
			return false;
		}
		#endregion

		#region Connection Methods
		/// <summary>
		/// Make a connection between the given pair of source and target elements
		/// </summary>
		/// <param name="source">The model element to use as the source of the connection</param>
		/// <param name="target">The model element to use as the target of the connection</param>
		/// <returns>A link representing the created connection</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Generated code.")]
		public static DslModeling::ElementLink Connect(DslModeling::ModelElement source, DslModeling::ModelElement target)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			
			if (CanAcceptSourceAndTarget(source, target))
			{
				if (source is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
				{
					if (target is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
					{
						global::Eleven.VS.Templates.Ado.Dsl.DomainEntity sourceAccepted = (global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)source;
						global::Eleven.VS.Templates.Ado.Dsl.DomainEntity targetAccepted = (global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)target;
						DslModeling::ElementLink result = new global::Eleven.VS.Templates.Ado.Dsl.DomainEntityReferencesTargetDomainEntities(sourceAccepted, targetAccepted);
						if (DslModeling::DomainClassInfo.HasNameProperty(result))
						{
							DslModeling::DomainClassInfo.SetUniqueName(result);
						}
						return result;
					}
				}
				
			}
			global::System.Diagnostics.Debug.Fail("Having agreed that the connection can be accepted we should never fail to make one.");
			throw new global::System.InvalidOperationException();
		}
		#endregion
 	}
	/// <summary>
	/// ConnectionBuilder class to provide logic for constructing connections between elements.
	/// </summary>
	public static partial class DomainEntityReferencesDomainEntityCollectionsBuilder
	{
		#region Accept Connection Methods
		/// <summary>
		/// Test whether a given model element is acceptable to this ConnectionBuilder as the source of a connection.
		/// </summary>
		/// <param name="candidate">The model element to test.</param>
		/// <returns>Whether the element can be used as the source of a connection.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		public static bool CanAcceptSource(DslModeling::ModelElement candidate)
		{
			if (candidate == null) return false;
			else if (candidate is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
			{ 
				return true;
			}
			else
				return false;
		}

		/// <summary>
		/// Test whether a given model element is acceptable to this ConnectionBuilder as the target of a connection.
		/// </summary>
		/// <param name="candidate">The model element to test.</param>
		/// <returns>Whether the element can be used as the target of a connection.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		public static bool CanAcceptTarget(DslModeling::ModelElement candidate)
		{
			if (candidate == null) return false;
			else if (candidate is global::Eleven.VS.Templates.Ado.Dsl.DomainEntityCollection)
			{ 
				return true;
			}
			else
				return false;
		}
		
		/// <summary>
		/// Test whether a given pair of model elements are acceptable to this ConnectionBuilder as the source and target of a connection
		/// </summary>
		/// <param name="candidateSource">The model element to test as a source</param>
		/// <param name="candidateTarget">The model element to test as a target</param>
		/// <returns>Whether the elements can be used as the source and target of a connection</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Generated code.")]
		public static bool CanAcceptSourceAndTarget(DslModeling::ModelElement candidateSource, DslModeling::ModelElement candidateTarget)
		{
			// Accepts null, null; source, null; source, target but NOT null, target
			if (candidateSource == null)
			{
				if (candidateTarget != null)
				{
					throw new global::System.ArgumentNullException("candidateSource");
				}
				else // Both null
				{
					return false;
				}
			}
			bool acceptSource = CanAcceptSource(candidateSource);
			// If the source wasn't accepted then there's no point checking targets.
			// If there is no target then the source controls the accept.
			if (!acceptSource || candidateTarget == null)
			{
				return acceptSource;
			}
			else // Check combinations
			{
				if (candidateSource is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
				{
					if (candidateTarget is global::Eleven.VS.Templates.Ado.Dsl.DomainEntityCollection)
					{
						global::Eleven.VS.Templates.Ado.Dsl.DomainEntity sourceDomainEntity = (global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)candidateSource;
						global::Eleven.VS.Templates.Ado.Dsl.DomainEntityCollection targetDomainEntityCollection = (global::Eleven.VS.Templates.Ado.Dsl.DomainEntityCollection)candidateTarget;
						if(targetDomainEntityCollection == null || global::Eleven.VS.Templates.Ado.Dsl.DomainEntityReferencesDomainEntityCollections.GetLinkToDomainEntity(targetDomainEntityCollection) != null) return false;
						if(targetDomainEntityCollection == null || sourceDomainEntity == null || global::Eleven.VS.Templates.Ado.Dsl.DomainEntityReferencesDomainEntityCollections.GetLinks(sourceDomainEntity, targetDomainEntityCollection).Count > 0) return false;
						return true;
					}
				}
				
			}
			return false;
		}
		#endregion

		#region Connection Methods
		/// <summary>
		/// Make a connection between the given pair of source and target elements
		/// </summary>
		/// <param name="source">The model element to use as the source of the connection</param>
		/// <param name="target">The model element to use as the target of the connection</param>
		/// <returns>A link representing the created connection</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Generated code.")]
		public static DslModeling::ElementLink Connect(DslModeling::ModelElement source, DslModeling::ModelElement target)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			
			if (CanAcceptSourceAndTarget(source, target))
			{
				if (source is global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)
				{
					if (target is global::Eleven.VS.Templates.Ado.Dsl.DomainEntityCollection)
					{
						global::Eleven.VS.Templates.Ado.Dsl.DomainEntity sourceAccepted = (global::Eleven.VS.Templates.Ado.Dsl.DomainEntity)source;
						global::Eleven.VS.Templates.Ado.Dsl.DomainEntityCollection targetAccepted = (global::Eleven.VS.Templates.Ado.Dsl.DomainEntityCollection)target;
						DslModeling::ElementLink result = new global::Eleven.VS.Templates.Ado.Dsl.DomainEntityReferencesDomainEntityCollections(sourceAccepted, targetAccepted);
						if (DslModeling::DomainClassInfo.HasNameProperty(result))
						{
							DslModeling::DomainClassInfo.SetUniqueName(result);
						}
						return result;
					}
				}
				
			}
			global::System.Diagnostics.Debug.Fail("Having agreed that the connection can be accepted we should never fail to make one.");
			throw new global::System.InvalidOperationException();
		}
		#endregion
 	}
 	
 	/// <summary>
	/// Handles interaction between the ConnectionBuilder and the corresponding ConnectionTool.
	/// </summary>
	internal partial class EntityConnectorToolConnectAction : DslDiagrams::ConnectAction
	{
		private DslDiagrams::ConnectionType[] connectionTypes;
		
		/// <summary>
		/// Constructs a new EntityConnectorToolConnectAction for the given Diagram.
		/// </summary>
		public EntityConnectorToolConnectAction(DslDiagrams::Diagram diagram): base(diagram, true) 
		{
		}
		
		/// <summary>
		/// Gets the cursor corresponding to the given mouse position.
		/// </summary>
		/// <remarks>
		/// Changes the cursor to Cursors.No before the first mouse click if the source shape is not valid.
		/// </remarks>
		public override global::System.Windows.Forms.Cursor GetCursor(global::System.Windows.Forms.Cursor currentCursor, DslDiagrams::DiagramClientView diagramClientView, DslDiagrams::PointD mousePosition)
		{
			if (this.MouseDownHitShape == null && currentCursor != global::System.Windows.Forms.Cursors.No)
			{
				DslDiagrams::DiagramHitTestInfo hitTestInfo = new DslDiagrams::DiagramHitTestInfo(diagramClientView);
				this.Diagram.DoHitTest(mousePosition, hitTestInfo);
				DslDiagrams::ShapeElement shape = hitTestInfo.HitDiagramItem.Shape;

				DslDiagrams::ConnectionType connectionType = GetConnectionTypes(shape, null)[0];
				string warningString = string.Empty;
				if (!connectionType.CanCreateConnection(shape, null, ref warningString))
				{
					return global::System.Windows.Forms.Cursors.No;
				}
			}
			return base.GetCursor(currentCursor, diagramClientView, mousePosition);
		}
		
		
		/// <summary>
		/// Returns the EntityConnectorToolConnectionType associated with this action.
		/// </summary>
		protected override DslDiagrams::ConnectionType[] GetConnectionTypes(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement)
		{
			if(this.connectionTypes == null)
			{
				this.connectionTypes = new DslDiagrams::ConnectionType[] { new EntityConnectorToolConnectionType() };
			}
			
			return this.connectionTypes;
		}
		
		private partial class EntityConnectorToolConnectionTypeBase : DslDiagrams::ConnectionType
		{
			/// <summary>
			/// Constructs a new the EntityConnectorToolConnectionType with the given ConnectionBuilder.
			/// </summary>
			protected EntityConnectorToolConnectionTypeBase() : base() {}
			
			private static DslDiagrams::ShapeElement RemovePassThroughShapes(DslDiagrams::ShapeElement shape)
			{
				if (shape is DslDiagrams::Compartment)
				{
					return shape.ParentShape;
				}
				DslDiagrams::SwimlaneShape swimlane = shape as DslDiagrams::SwimlaneShape;
				if (swimlane != null && swimlane.ForwardDragDropToParent)
				{
					return shape.ParentShape;
				}
				return shape;
			}
						
			/// <summary>
			/// Called by the base ConnectAction class to determine if the given shapes can be connected.
			/// </summary>
			/// <remarks>
			/// This implementation delegates calls to the ConnectionBuilder DomainEntityReferencesTargetDomainEntitiesBuilder.
			/// </remarks>
			public override bool CanCreateConnection(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement, ref string connectionWarning)
			{
				bool canConnect = true;
				
				if(sourceShapeElement == null) throw new global::System.ArgumentNullException("sourceShapeElement");
				sourceShapeElement = RemovePassThroughShapes(sourceShapeElement);
				DslModeling::ModelElement sourceElement = sourceShapeElement.ModelElement;
				if(sourceElement == null) sourceElement = sourceShapeElement;
				
				DslModeling::ModelElement targetElement = null;
				if (targetShapeElement != null)
				{
					targetShapeElement = RemovePassThroughShapes(targetShapeElement);
					targetElement = targetShapeElement.ModelElement;
					if(targetElement == null) targetElement = targetShapeElement;
			
				}

				// base.CanCreateConnection must be called to check whether existing Locks prevent this link from getting created.	
				canConnect = base.CanCreateConnection(sourceShapeElement, targetShapeElement, ref connectionWarning);
				if (canConnect)
				{				
					if(targetShapeElement == null)
					{
						return DomainEntityReferencesTargetDomainEntitiesBuilder.CanAcceptSource(sourceElement);
					}
					else
					{				
						return DomainEntityReferencesTargetDomainEntitiesBuilder.CanAcceptSourceAndTarget(sourceElement, targetElement);
					}
				}
				else
				{
					//return false
					return canConnect;
				}
			}
						
			/// <summary>
			/// Called by the base ConnectAction class to ask whether the given source and target are valid.
			/// </summary>
			/// <remarks>
			/// Always return true here, to give CanCreateConnection a chance to decide.
			/// </remarks>
			public override bool IsValidSourceAndTarget(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement)
			{
				return true;
			}
			
			/// <summary>
			/// Called by the base ConnectAction class to create the underlying relationship.
			/// </summary>
			/// <remarks>
			/// This implementation delegates calls to the ConnectionBuilder DomainEntityReferencesTargetDomainEntitiesBuilder.
			/// </remarks>
			public override void CreateConnection(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement, DslDiagrams::PaintFeedbackArgs paintFeedbackArgs)
			{
				if(sourceShapeElement == null) throw new global::System.ArgumentNullException("sourceShapeElement");
				if(targetShapeElement == null) throw new global::System.ArgumentNullException("targetShapeElement");
				
				sourceShapeElement = RemovePassThroughShapes(sourceShapeElement);
				targetShapeElement = RemovePassThroughShapes(targetShapeElement);
				
				DslModeling::ModelElement sourceElement = sourceShapeElement.ModelElement;
				if(sourceElement == null) sourceElement = sourceShapeElement;
				DslModeling::ModelElement targetElement = targetShapeElement.ModelElement;
				if(targetElement == null) targetElement = targetShapeElement;
				DomainEntityReferencesTargetDomainEntitiesBuilder.Connect(sourceElement, targetElement);
			}
		}
		
		private partial class EntityConnectorToolConnectionType : EntityConnectorToolConnectionTypeBase
		{
			/// <summary>
			/// Constructs a new the EntityConnectorToolConnectionType with the given ConnectionBuilder.
			/// </summary>
			public EntityConnectorToolConnectionType() : base() {}
		}
	}
 	
 	/// <summary>
	/// Handles interaction between the ConnectionBuilder and the corresponding ConnectionTool.
	/// </summary>
	internal partial class EntityCollectionConnectorToolConnectAction : DslDiagrams::ConnectAction
	{
		private DslDiagrams::ConnectionType[] connectionTypes;
		
		/// <summary>
		/// Constructs a new EntityCollectionConnectorToolConnectAction for the given Diagram.
		/// </summary>
		public EntityCollectionConnectorToolConnectAction(DslDiagrams::Diagram diagram): base(diagram, true) 
		{
		}
		
		/// <summary>
		/// Gets the cursor corresponding to the given mouse position.
		/// </summary>
		/// <remarks>
		/// Changes the cursor to Cursors.No before the first mouse click if the source shape is not valid.
		/// </remarks>
		public override global::System.Windows.Forms.Cursor GetCursor(global::System.Windows.Forms.Cursor currentCursor, DslDiagrams::DiagramClientView diagramClientView, DslDiagrams::PointD mousePosition)
		{
			if (this.MouseDownHitShape == null && currentCursor != global::System.Windows.Forms.Cursors.No)
			{
				DslDiagrams::DiagramHitTestInfo hitTestInfo = new DslDiagrams::DiagramHitTestInfo(diagramClientView);
				this.Diagram.DoHitTest(mousePosition, hitTestInfo);
				DslDiagrams::ShapeElement shape = hitTestInfo.HitDiagramItem.Shape;

				DslDiagrams::ConnectionType connectionType = GetConnectionTypes(shape, null)[0];
				string warningString = string.Empty;
				if (!connectionType.CanCreateConnection(shape, null, ref warningString))
				{
					return global::System.Windows.Forms.Cursors.No;
				}
			}
			return base.GetCursor(currentCursor, diagramClientView, mousePosition);
		}
		
		
		/// <summary>
		/// Returns the EntityCollectionConnectorToolConnectionType associated with this action.
		/// </summary>
		protected override DslDiagrams::ConnectionType[] GetConnectionTypes(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement)
		{
			if(this.connectionTypes == null)
			{
				this.connectionTypes = new DslDiagrams::ConnectionType[] { new EntityCollectionConnectorToolConnectionType() };
			}
			
			return this.connectionTypes;
		}
		
		private partial class EntityCollectionConnectorToolConnectionTypeBase : DslDiagrams::ConnectionType
		{
			/// <summary>
			/// Constructs a new the EntityCollectionConnectorToolConnectionType with the given ConnectionBuilder.
			/// </summary>
			protected EntityCollectionConnectorToolConnectionTypeBase() : base() {}
			
			private static DslDiagrams::ShapeElement RemovePassThroughShapes(DslDiagrams::ShapeElement shape)
			{
				if (shape is DslDiagrams::Compartment)
				{
					return shape.ParentShape;
				}
				DslDiagrams::SwimlaneShape swimlane = shape as DslDiagrams::SwimlaneShape;
				if (swimlane != null && swimlane.ForwardDragDropToParent)
				{
					return shape.ParentShape;
				}
				return shape;
			}
						
			/// <summary>
			/// Called by the base ConnectAction class to determine if the given shapes can be connected.
			/// </summary>
			/// <remarks>
			/// This implementation delegates calls to the ConnectionBuilder DomainEntityReferencesDomainEntityCollectionsBuilder.
			/// </remarks>
			public override bool CanCreateConnection(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement, ref string connectionWarning)
			{
				bool canConnect = true;
				
				if(sourceShapeElement == null) throw new global::System.ArgumentNullException("sourceShapeElement");
				sourceShapeElement = RemovePassThroughShapes(sourceShapeElement);
				DslModeling::ModelElement sourceElement = sourceShapeElement.ModelElement;
				if(sourceElement == null) sourceElement = sourceShapeElement;
				
				DslModeling::ModelElement targetElement = null;
				if (targetShapeElement != null)
				{
					targetShapeElement = RemovePassThroughShapes(targetShapeElement);
					targetElement = targetShapeElement.ModelElement;
					if(targetElement == null) targetElement = targetShapeElement;
			
				}

				// base.CanCreateConnection must be called to check whether existing Locks prevent this link from getting created.	
				canConnect = base.CanCreateConnection(sourceShapeElement, targetShapeElement, ref connectionWarning);
				if (canConnect)
				{				
					if(targetShapeElement == null)
					{
						return DomainEntityReferencesDomainEntityCollectionsBuilder.CanAcceptSource(sourceElement);
					}
					else
					{				
						return DomainEntityReferencesDomainEntityCollectionsBuilder.CanAcceptSourceAndTarget(sourceElement, targetElement);
					}
				}
				else
				{
					//return false
					return canConnect;
				}
			}
						
			/// <summary>
			/// Called by the base ConnectAction class to ask whether the given source and target are valid.
			/// </summary>
			/// <remarks>
			/// Always return true here, to give CanCreateConnection a chance to decide.
			/// </remarks>
			public override bool IsValidSourceAndTarget(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement)
			{
				return true;
			}
			
			/// <summary>
			/// Called by the base ConnectAction class to create the underlying relationship.
			/// </summary>
			/// <remarks>
			/// This implementation delegates calls to the ConnectionBuilder DomainEntityReferencesDomainEntityCollectionsBuilder.
			/// </remarks>
			public override void CreateConnection(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement, DslDiagrams::PaintFeedbackArgs paintFeedbackArgs)
			{
				if(sourceShapeElement == null) throw new global::System.ArgumentNullException("sourceShapeElement");
				if(targetShapeElement == null) throw new global::System.ArgumentNullException("targetShapeElement");
				
				sourceShapeElement = RemovePassThroughShapes(sourceShapeElement);
				targetShapeElement = RemovePassThroughShapes(targetShapeElement);
				
				DslModeling::ModelElement sourceElement = sourceShapeElement.ModelElement;
				if(sourceElement == null) sourceElement = sourceShapeElement;
				DslModeling::ModelElement targetElement = targetShapeElement.ModelElement;
				if(targetElement == null) targetElement = targetShapeElement;
				DomainEntityReferencesDomainEntityCollectionsBuilder.Connect(sourceElement, targetElement);
			}
		}
		
		private partial class EntityCollectionConnectorToolConnectionType : EntityCollectionConnectorToolConnectionTypeBase
		{
			/// <summary>
			/// Constructs a new the EntityCollectionConnectorToolConnectionType with the given ConnectionBuilder.
			/// </summary>
			public EntityCollectionConnectorToolConnectionType() : base() {}
		}
	}
}

