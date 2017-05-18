namespace CarDesign.Model
{
  using System;
  using Objectivity.Db;
  public partial class Engine
  {

    #region Constructors

    public Engine(PlacementConditions placementConditions) : base(placementConditions, _schemaClass)
    {
    }

    #endregion Constructors
  }
}
