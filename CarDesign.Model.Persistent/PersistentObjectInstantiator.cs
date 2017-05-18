using Objectivity.Db;

public static class PersistentObjectInstantiator
{
  public static void TiePersistentClassesToFdSchema()
  {
    CarDesign.Model.Rotor.TieToFdSchema();
    CarDesign.Model.Stator.TieToFdSchema();
    CarDesign.Model.CylinderHead.TieToFdSchema();
    CarDesign.Model.Wheel.TieToFdSchema();
    CarDesign.Model.Engine.TieToFdSchema();
    CarDesign.Model.Cylinder.TieToFdSchema();
    CarDesign.Model.Car.TieToFdSchema();
  }


  public static IReferenceableObject Instantiate(int classNumber, ObjectId id)
  {
    switch (classNumber)
    {
      case 1000000 : return CarDesign.Model.Rotor.CreateProxyForId(id);
      case 1000001 : return CarDesign.Model.Stator.CreateProxyForId(id);
      case 1000002 : return CarDesign.Model.CylinderHead.CreateProxyForId(id);
      case 1000003 : return CarDesign.Model.Wheel.CreateProxyForId(id);
      case 1000004 : return CarDesign.Model.Engine.CreateProxyForId(id);
      case 1000005 : return CarDesign.Model.Cylinder.CreateProxyForId(id);
      case 1000006 : return CarDesign.Model.Car.CreateProxyForId(id);
      default : return null;
    }
  }
}
