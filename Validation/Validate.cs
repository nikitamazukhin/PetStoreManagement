namespace DatabaseApp.Validation;

public static class Validate
{
    public static void NotNull(object value) 
    {
        ArgumentNullException.ThrowIfNull(value, nameof(value));
    }

    public static void StringNotNullOrEmpty(string value) 
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException(nameof(value));
        }
    }

    public static void StringHasLength(string str, int length)
    {
        StringNotNullOrEmpty(str);

        if (str.Length != length) 
        {
            throw new ArgumentException("String " + nameof(str) + " isn't length " + length);
        }
    }
}
