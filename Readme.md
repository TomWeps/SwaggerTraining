# Swagger (OpenApi) & Tools - Usage Examples

## Swashbuckle: Swagger Generator
[MSDN: Get started with Swashbuckle and ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.0&tabs=visual-studio)

Worth to know:
- A lot of customization and extension possibilities - see Swagger Setup
https://github.com/domaindrivendev/Swashbuckle.AspNetCore
- `[ProducesResponseType(StatusCodes.Status..., Type = typeof(IfAnotherTypeIsReturned))]`
- `[Produces("application/json")]` usually better set globally
- Comments for actions and DTO objects
- DataAnnotations can be used too (like required, default)
- Other comment type - 'Example'
- Enums Customizations
  - swagger Configuration `DescribeAllEnumsAsStrings()`
  - `[JsonConverter(typeof(StringEnumConverter))]`
  - `[EnumMember(Value="CustomEnumStringValue")]`
   

## Manifest
  - Can be used by a variety of rest clients (for example Postman)
  - https://swagger.io/docs/specification/2-0/basic-structure/

## Code Generators
- [swagger-codegen](https://swagger.io/tools/swagger-codegen/)
- [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio)
- and more ...

## Moks
- [stoplight prism](https://stoplight.io/open-source/prism/)
- and more ...

## Others
- https://swagger.io/tools/
