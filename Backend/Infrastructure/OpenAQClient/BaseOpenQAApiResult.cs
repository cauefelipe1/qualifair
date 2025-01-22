namespace Infrastructure.OpenAQClient
{
    /// <summary>
    /// Represents metadata information for the OpenAQ API response.
    /// </summary>
    public class OpenQAMetaData
    {
        /// <summary>
        /// The API name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// API Website
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Current page number of the API response.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Limit of items per page in the API response.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Total number of items found in the API response.
        /// </summary>
        public string Found { get; set; }
    }

    /// <summary>
    /// Represents the base result of an OpenAQ API response.
    /// </summary>
    public class BaseOpenQAApiResult
    {
        /// <summary>
        /// Gets or sets the metadata information of the API response.
        /// </summary>
        public OpenQAMetaData Meta { get; set; }
    }

    /// <summary>
    /// Represents the result of an OpenAQ API response with a specific result type.
    /// </summary>
    /// <typeparam name="TResult">The type of the result items.</typeparam>
    public class OpenQAApiResult<TResult>
    {
        /// <summary>
        /// Gets or sets the metadata information of the API response.
        /// </summary>
        public OpenQAMetaData Meta { get; set; }

        /// <summary>
        /// Gets or sets the list of result items.
        /// </summary>
        public List<TResult> Results { get; set; }
    }
}