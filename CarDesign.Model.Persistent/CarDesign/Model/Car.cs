namespace CarDesign.Model
{
  using System;
  using Objectivity.Db;
  public partial class Car
  {
    // This is an edit test
    #region Constructors

    public Car(PlacementConditions placementConditions) : base(placementConditions, _schemaClass)
    {
    }

    #endregion Constructors
  }
}
