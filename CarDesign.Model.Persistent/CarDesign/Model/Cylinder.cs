namespace CarDesign.Model
{
  using System;
  using Objectivity.Db;
  public partial class Cylinder
  {

    #region Constructors

    public Cylinder(PlacementConditions placementConditions) : base(placementConditions, _schemaClass)
    {
    }

    #endregion Constructors
  }
}
