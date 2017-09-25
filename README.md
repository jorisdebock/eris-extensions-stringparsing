# String parsing extensions

String parsing extensions that wrap TryParse methods in order to use it in a more fluent way.

A few examples:

```c#
"123".ToByte();
"1234".ToShort();
"1234".ToInt();
"1234".ToLong();

"https://google.com".ToUri();
```
