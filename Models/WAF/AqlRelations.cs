// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using WAF.Data.Query;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;

namespace WAF.Data.Query.SimpleCompanyWebsite {

    public abstract class SqlMyRelation {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_my_relation", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite{

    [System.Serializable]
    public abstract class AqlMyRelation{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("d197e26c-bc6c-4b71-bda4-5a81bcd86dd5") );
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite{

    [System.Serializable]
    public class AqlAliasMyRelation: AqlAliasRelation {

        public AqlAliasMyRelation(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlMyRelation.Relation) {

        }
        public AqlAliasMyRelation(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlMyRelation.Relation, onParent ) {

        }
        public AqlAliasMyRelation(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlMyRelation.Relation, onChild ) {

        }
        public AqlAliasMyRelation(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlMyRelation.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Content.SimpleCompanyWebsite{
    [System.Serializable]
    public partial class MyRelation: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("d197e26c-bc6c-4b71-bda4-5a81bcd86dd5");
            }
        }

    }
}
namespace WAF.Engine.Content.SimpleCompanyWebsite{

    public enum Power_Types_Enumeration: int{

        Solar_Power=0,
        Wind_Power=1,
        Water_Power=2,
        Other_Power_Types=3,
    }
}
