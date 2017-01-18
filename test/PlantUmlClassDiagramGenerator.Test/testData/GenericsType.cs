namespace PlantUmlClassDiagramGeneratorTest
{
    class GenericsType
    {
        public object Value { get; }
    }

    class GenericsType<T>
    {
        public T Value { get; }
    }

    class GenericsType<T1, T2>
    {
        public T1 Value1 { get; }
        public T2 Value2 { get; }
    }

    class SubClass : GenericsType<string, int>
    {
        public new string Value1 { get; }
        public new int Value2 { get; }
    }

    class SubClass<T>: GenericsType<GenericsType<int>, T>
    {
        public new GenericsType<int> Value1 { get; }
        public new T Value2 { get; }
    }
}
