//*****************************************************************************
//   This partial class file has been autogenerated by an Objectivity tool.   
//   It provides all of the persistence support for the application class.    
//
//   Do not modify this file directly; instead, change persistence     
//   characteristics by opening and editing the *.pdd file   
//   using the Persistence Designer. 
//*****************************************************************************

namespace CarDesign.Model
{
  using System;
  using Objectivity.Db;
  using Objectivity.Db.Internal;
  using Objectivity.Db.Collections.Specialized;
  public partial class Stator : ReferenceableObject
  {
    static Stator() {}

    private static readonly SchemaClass _schemaClass = new SchemaClass("CarDesign.Model.Stator", 1000001, 1001);

    #region Fields
    private static readonly SchemaAttribute _idField = new SchemaAttribute(_schemaClass, 2, "Id", AttributeKinds.UInt32);
    #endregion Fields

    #region Constructors

    protected Stator(ObjectId id) : base(id) {}
    protected Stator(PlacementConditions placementConditions, SchemaClass sc) : base(placementConditions, sc)
    {
    }


    #endregion Constructors

    #region Helpers

    new public static Stator CreateProxyForId(ObjectId id)
    {
      return new Stator(id);
    }

    new public static int GetClassTypeNumber()
    {
      return _schemaClass.getShapeNumber();
    }


    public static void TieToFdSchema()
    {
      // Empty on purpose.
      // Via static constructor ensures all static schema fields are initialized.
    }

    #endregion Helpers

    #region Properties
    public uint Id
    {
      get {return GetUInt32Value(_idField);}
      set {SetUInt32Value(_idField, value);}
    }

    #endregion Properties
  }
}
