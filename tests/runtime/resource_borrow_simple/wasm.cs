using System.Diagnostics;
using ResourceBorrowSimpleWorld;

namespace ResourceBorrowSimpleWorld
{
  public class ResourceBorrowSimpleWorldImpl : IResourceBorrowSimpleWorld
  {
    public static void TestImports(){
      var r = new IResourceBorrowSimpleWorld.RBorrow { Handle = 1 };
      ResourceBorrowSimpleWorld.exports.ResourceBorrowSimpleWorld.Test(r);
     }
  }
}