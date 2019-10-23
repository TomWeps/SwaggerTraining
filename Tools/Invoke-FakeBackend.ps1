$rootPath = $PSScriptRoot
$swaggerDocUrl = "http://localhost:58236/swagger/v1/swagger.json"
$swaggerManifestPath = Join-Path -Path $rootPath -ChildPath 'swagger.json'
$dockerContainerName = "ToDoApiFake"

Write-Host "Getting swagger manifest"

if(Test-Path $swaggerManifestPath){
    Remove-Item -Path $swaggerManifestPath -Force -ErrorAction Continue
}

Invoke-WebRequest -Uri $swaggerDocUrl -OutFile $swaggerManifestPath


Write-Host "Starting Docker $dockerContainerName"


Invoke-Expression "docker stop $dockerContainerName" 2>&1 | out-null
$command = "docker run --name $dockerContainerName --rm -p 4010:4010 -v $rootPath`:/tmp stoplight/prism:3 mock -d -h 0.0.0.0 /tmp/swagger.json"
Invoke-Expression $command

