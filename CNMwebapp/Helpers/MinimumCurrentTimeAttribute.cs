using System;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class MinimumCurrentTimeAttribute : Attribute
{
    public void SetValue(object obj)
    {
        if (obj is DateTime dateTime)
        {
            dateTime = DateTime.Now;
        }
    }
}
