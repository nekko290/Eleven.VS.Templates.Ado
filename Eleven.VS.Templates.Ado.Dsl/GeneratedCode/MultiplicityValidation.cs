﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslValidation = global::Microsoft.VisualStudio.Modeling.Validation;
namespace Eleven.VS.Templates.Ado.Dsl
{
	[DslValidation::ValidationState(DslValidation::ValidationState.Enabled)]
	public partial class DomainEntityCollection
	{
		/// <summary>
		/// Checks that the relationships that have a multiplicity of One or OneMany do actually have a link.
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Generated code.")]
		[DslValidation::ValidationMethod(DslValidation::ValidationCategories.Open | DslValidation::ValidationCategories.Save | DslValidation::ValidationCategories.Menu)]
		private void ValidateDomainEntityCollectionMultiplicity (DslValidation::ValidationContext context)
		{
			if (this.DomainEntity == null)
			{
				context.LogViolation(DslValidation::ViolationType.Error,
					string.Format(global::System.Globalization.CultureInfo.CurrentCulture, 
						Eleven.VS.Templates.Ado.Dsl.ElevenEntityModelDomainModel.SingletonResourceManager.GetString("MinimumMultiplicityMissingLink"), 
						"DomainEntityCollection", this.Name, "DomainEntity"),
						"DSL0001", this);
			}
		} // ValidateDomainEntityCollectionMultiplicity
	} // class DomainEntityCollection
} // Eleven.VS.Templates.Ado.Dsl

	
 