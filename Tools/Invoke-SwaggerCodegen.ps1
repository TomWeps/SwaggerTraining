$rootPath = $PSScriptRoot

$swaggerDocUrl = "http://localhost:58236/swagger/v1/swagger.json"
$swaggerGenLibDownloadUrl = 'https://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.4.9/swagger-codegen-cli-2.4.9.jar'
$swaggerGenLibName = $swaggerGenLibDownloadUrl.Split('/')[-1]
$swaggerGenLibPath = Join-Path -Path $rootPath -ChildPath $swaggerGenLibName
$destinationPath = Join-Path -Path $rootPath -ChildPath 'CodegenOutput'

Write-Host "Swagger Proxy Generator initialized! API doc location address: $swaggerDocUrl"

# Download Swagger script if not exists
if (!(Test-Path -Path $swaggerGenLibPath))
{
    Write-Host "Downloading swagger generator..."
    Invoke-RestMethod -Uri $swaggerGenLibDownloadUrl -OutFile $swaggerGenLibPath
}

if(Test-Path -Path $destinationPath){
    Remove-Item -Path $destinationPath -Recurse -Force | Out-Null
} 

New-Item -Path $destinationPath  -ItemType Directory | Out-Null




# Generating swagger proxies
Write-Host "Generating swagger proxies for angular..."
$codeGenCommand =  "java -jar `"$swaggerGenLibPath`" generate -i $swaggerDocUrl -l typescript-angular -o `"$destinationPath`" --additional-properties ngVersion=6"
$codeGenCommand
Invoke-Expression $codeGenCommand 2>&1 | out-null


if((Get-ChildItem -Path (Get-Location)).Length -eq 0)
{
    Write-Warning "No proxies generated. Make sure swagger API doc endpoint ($swaggerDocUrl) is accessible. Backend API is not launched?"
    return
}
