namespace DatabaseInterpreter;

public class Dbschema
{
    public string Owner { get; set; } = default!;
    public List<Table>? Tables { get; set; }
    public List<View>? Views { get; set; }

}

public class View
{

}

public class Table
{
    public string Name { get; set; } = default!;

    /// <summary>
    /// Schema owner of the table, the default parameters is SFD = Sql For Dummies.
    /// </summary>
    public string Schema { get; set; } = "SFD";
    public List<Column>? Columns { get; set; }
    public List<Column>? PrimaryKeys { get; set; }
    public List<ForgeinKey>? ForeignKey { get; set; }
    public List<Constraints>? Constraints { get; set; }
    public List<Triggers>? Triggers { get; set; }
    public List<Indexes>? Indexes { get; set; }
    public List<Statistics>? Statistics { get; set; }

}

public class ForgeinKey
{
}

public class Statistics
{
}

public class Indexes
{
}

public class Triggers
{
}

public class Column
{
    public string Name { get; set; } = default!;
    public bool? IsPrimaryKey { get; set; }
    public bool AllowNulls { get; set; } = true;
    public string? DbType { get; set; }
    public string? CType { get; set; }
    public int? Length { get; set; }
    public string? Collation { get; set; }
    public int? Precision { get; set; }
    public int? Scale { get; set; }

    public bool FullText { get; set; }
    public string GeneratedAlwaysType { get; set; } // enum => Convert
    public bool IsHidden { get; set; }
    public bool IsDroppedLedgerColumn { get; set; }
    public bool NotForReplication { get; set; }

    /// <summary>
    /// information about the column.
    /// </summary>
    public string? Description { get; set; }

}

public class Constraints
{
}