namespace Boolean_Extended
{
    public static class Program
    {
        public static bool isNull(this object obj)
        {
            if (obj is null) return true;
            return false;
        }
    }
}
