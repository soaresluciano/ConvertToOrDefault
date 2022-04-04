# ConverterHelper

![Build status](https://github.com/soaresluciano/ConverterHelper/workflows/Build%20and%20Tests/badge.svg)
[![codecov](https://codecov.io/gh/soaresluciano/ConverterHelper/branch/master/graph/badge.svg?token=ZGU157U8K0)](https://codecov.io/gh/soaresluciano/ConverterHelper)
[![NuGet version](https://img.shields.io/nuget/v/ConverterHelper.svg?style=flat&label=NuGet&logo=nuget)](https://www.nuget.org/packages/ConverterHelper)

Helper for easy and elegant type conversions, taking care of nullables, enums, System.DBNull and other types inherit from System.IConvertible. The method tries to convert to the specified type; if the conversion fails, there is an option to define a fallback value to be returned as a result.

## Example:
int converted = someObject.ConvertToOrDefault<int>(-1);
