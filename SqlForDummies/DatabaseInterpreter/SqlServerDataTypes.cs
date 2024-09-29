namespace DatabaseInterpreter;

public class SqlServerDataTypes
{
    // numerics
}
// https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
public enum SqlServerDataType
{
    // Exact Numerics
    TinyInt,
    SmallInt,
    Int,
    BigInt,
    Bit,
    Decimal,
    Numeric,
    Money,
    SmallMoney,
    // Approximate Numerics
    Float,
    Real,
    // Date And Time
    Date,
    Time,
    DateTime2,
    DateTimeOffset,
    DateTime,
    SmallDateTime,
    // Character Strings
    Char,
    Varchar,
    Text,
    // Unicode Characters Strings
    NChar,
    NVarchar,
    NText,
    // Binary Strings
    Binary,
    VarBinary,
    Image,
    // Other Data Types
    Cursor,
    Geography,
    Geometry,
    Hierarchyid,
    Json,
    Rowversion,
    Sql_variant,
    Table,
    Uniqueidentifier,
    Xml

}
