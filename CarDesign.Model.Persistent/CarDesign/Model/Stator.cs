namespace CarDesign.Model
{
  using System;
  using Objectivity.Db;
  public partial class Stator
  {

    #region Constructors

    public Stator(PlacementConditions placementConditions) : base(placementConditions, _schemaClass)
    {
    }

    #endregion Constructors
  }
}
