namespace Infrastructure.Location;


/// <summary>
/// Represents the coordinates of the location.
/// </summary>
public class CoordinatesOpenQADTO
{
    /// <summary>
    /// Gets or sets the latitude of the location.
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude of the location.
    /// </summary>
    public double? Longitude { get; set; }
}

/// <summary>
/// Represents the parameter details of a sensor.
/// </summary>
public class ParameterOpenQADTO
{
    /// <summary>
    /// Gets or sets the ID of the parameter.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the parameter.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the units of the parameter.
    /// </summary>
    public string? Units { get; set; }

    /// <summary>
    /// Gets or sets the display name of the parameter.
    /// </summary>
    public string? DisplayName { get; set; }
}


/// <summary>
/// Represents a sensor at the location.
/// </summary>
public class SensorOpenQADTO
{
    /// <summary>
    /// Gets or sets the ID of the sensor.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the sensor.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the parameter details of the sensor.
    /// </summary>
    public ParameterOpenQADTO? Parameter { get; set; }
}

/// <summary>
/// Represents an instrument at the location.
/// </summary>
public class InstrumentOpenQADTO
{
    /// <summary>
    /// Gets or sets the ID of the instrument.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the instrument.
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// Represents the provider details.
/// </summary>
public class ProviderOpenQADTO
{
    /// <summary>
    /// Gets or sets the ID of the provider.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the provider.
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// Represents the owner details.
/// </summary>
public class OwnerOpenQADTO
{
    /// <summary>
    /// Gets or sets the ID of the owner.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the owner.
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// Represents the country details.
/// </summary>
public class CountryOpenQADTO
{
    /// <summary>
    /// Gets or sets the ID of the country.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets the code of the country.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Gets or sets the name of the country.
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// Represents a location with various details.
/// </summary>
public class LocationOpenQADTO
{
    /// <summary>
    /// Gets or sets the ID of the location.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the location.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the locality of the location.
    /// </summary>
    // public string? Locality { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the timezone of the location.
    // /// </summary>
    // public string? Timezone { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the country details of the location.
    // /// </summary>
    // public CountryOpenQADTO? Country { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the owner details of the location.
    // /// </summary>
    // public OwnerOpenQADTO? Owner { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the provider details of the location.
    // /// </summary>
    // public ProviderOpenQADTO? Provider { get; set; }
    //
    // /// <summary>
    // /// Gets or sets a value indicating whether the location is mobile.
    // /// </summary>
    // public bool? IsMobile { get; set; }
    //
    // /// <summary>
    // /// Gets or sets a value indicating whether the location is a monitor.
    // /// </summary>
    // public bool? IsMonitor { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the list of instruments at the location.
    // /// </summary>
    // public List<InstrumentOpenQADTO>? Instruments { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the list of sensors at the location.
    // /// </summary>
    // public List<SensorOpenQADTO>? Sensors { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the coordinates of the location.
    // /// </summary>
    // public CoordinatesOpenQADTO? Coordinates { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the licenses of the location.
    // /// </summary>
    // public string? Licenses { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the bounds of the location.
    // /// </summary>
    // public List<double>? Bounds { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the distance of the location.
    // /// </summary>
    // public string? Distance { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the first datetime of the location.
    // /// </summary>
    // public string? DatetimeFirst { get; set; }
    //
    // /// <summary>
    // /// Gets or sets the last datetime of the location.
    // /// </summary>
    // public string? DatetimeLast { get; set; }
}