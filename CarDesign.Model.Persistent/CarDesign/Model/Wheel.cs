namespace CarDesign.Model
{
  using System;
  using Objectivity.Db;
  public partial class Wheel
  {

    #region Constructors

    public Wheel(PlacementConditions placementConditions) : base(placementConditions, _schemaClass)
    {
    }

    #endregion Constructors
  }
}
