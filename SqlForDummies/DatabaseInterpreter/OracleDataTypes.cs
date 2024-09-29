namespace DatabaseInterpreter;

// https://docs.oracle.com/en/database/oracle/oracle-database/19/sqlrf/Data-Types.html
public class OracleDataTypes
{
}

public enum OracleDataType
{
    Varchar2,
    NVarchar2,
    Number,
    Float,
    Long,
    Date,
    BinaryFloat,
    BinaryDouble,
    Timestamp, // recheck  has 3 types
    IntervalYear,
    IntervalDay,
    Raw,
    LongRaw,
    URowID,
    Char,
    NChar,
    Clob,
    NClob,
    Blob,
    BFile,
    // ORacle Supplied Types
    AnyTypes,
    AnyType,
    XMLType

}