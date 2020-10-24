namespace DefaultUnDo
{
    /// <summary>
    /// Provides data for when an operation is performed on an undo collection.
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
        /// Initializes a new instance of the <see cref="UnDoCollectionOperation"/> class.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="action"></param>
        public UnDoCollectionOperation(object collection, UnDoCollectionAction action)
        {
            Collection = collection;
            Action = action;
        }
    }
}
