# ConverterHelper

Helper for easy and elegant type conversions, taking care of: nullables, enums, System.DBNull and other types inherit from System.IConvertible. The method try convert to specified type, if the conversion fail, there is an option to define a fallback value to be returned as result.

## Example:
int converted = someObject.ConvertToOrDefault<int>(-1);

## Nuget:
https://www.nuget.org/packages/ConverterHelper/
