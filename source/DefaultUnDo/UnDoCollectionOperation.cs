namespace DefaultUnDo
{
    /// <summary>
    /// Provides data for the operation about to be performed on an undo collection.
    /// </summary>
    public readonly struct UnDoCollectionOperation
    {
        /// <summary>
        /// Gets the collection on which the action is performed.
        /// </summary>
        public object Collection { get; }
        /// <summary>
        /// Gets the action performed.
        /// </summary>
        public UnDoCollectionAction Action { get; }

        /// <summary>
        /// Gets the parameters of the action performed.
        /// </summary>
        public object[] Parameters { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnDoCollectionOperation"/> struct.
        /// </summary>
        /// <param name="collection">The collection on which the action is performed.</param>
        /// <param name="action">The action performed.</param>
        /// <param name="parameters">The parameters of the action performed.</param>
        public UnDoCollectionOperation(object collection, UnDoCollectionAction action, params object[] parameters)
        {
            Collection = collection;
            Action = action;
            Parameters = parameters;
        }
    }
}
