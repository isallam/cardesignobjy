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
  public partial class Cylinder : ReferenceableObject
  {
    static Cylinder() {}

    private static readonly SchemaClass _schemaClass = new SchemaClass("CarDesign.Model.Cylinder", 1000005, 1001);

    #region Fields
    private static readonly SchemaAttribute _idField = new SchemaAttribute(_schemaClass, 2, "Id", AttributeKinds.UInt32);
    private static readonly SchemaAttribute _headField = new SchemaAttribute(_schemaClass, 3, "Head", AttributeKinds.Reference, 1000002);
    #endregion Fields

    #region Constructors

    protected Cylinder(ObjectId id) : base(id) {}
    protected Cylinder(PlacementConditions placementConditions, SchemaClass sc) : base(placementConditions, sc)
    {
    }


    #endregion Constructors

    #region Helpers

    new public static Cylinder CreateProxyForId(ObjectId id)
    {
      return new Cylinder(id);
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

    public CylinderHead Head
    {
      get {return (CylinderHead) GetObject(_headField);}
      set {SetObject(_headField, value);}
    }

    #endregion Properties
  }
}
