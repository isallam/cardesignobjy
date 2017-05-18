namespace CarDesign.Model
{
  using System;
  using Objectivity.Db;
  public partial class Rotor
  {

    #region Constructors

    public Rotor(PlacementConditions placementConditions) : base(placementConditions, _schemaClass)
    {
    }

    #endregion Constructors
  }
}
