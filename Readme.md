# Swagger (OpenApi) & Tools - Usage Examples

*[Let's start with clarifying Swagger vs OpenApi](https://swagger.io/blog/api-strategy/difference-between-swagger-and-openapi/)*
- OpenAPI = Specification
- Swagger = Tools for implementing the specification


*Versions*
 - OpenAPI 2 - Swagger ver.2 - Swashbuckle (.Net) v4
 - OpenAPI 3 - Swagger ver.3 - Swashbuckle (.Net) v5 **RC**
  
   [whats-new-in-openapi-3-0](https://swagger.io/blog/news/whats-new-in-openapi-3-0/)
   [A Visual Guide to What's New in Swagger 3.0](https://blog.readme.io/an-example-filled-guide-to-swagger-3-2/)

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
- [Swagger-Codegen](https://swagger.io/tools/swagger-codegen/)

  Run script: `Tools\Invoke-SwaggerCodegen.ps1`

- [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio)
  
- and more ...

## Moks
- [Stoplight Prism](https://stoplight.io/open-source/prism/)

  Run script: `Tools\Invoke-FakeBackend.ps1`

- [Swagmock](https://www.npmjs.com/package/swagmock)
- [Postman as Mock Server](https://learning.getpostman.com/docs/postman/mock_servers/mocking_with_examples/)
- and more ...

## Others
- Validators, Manifest Designers, Server Generators etc.
- https://swagger.io/tools/
