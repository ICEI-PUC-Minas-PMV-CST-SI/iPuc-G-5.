# Inventario - inicia o sistema no PowerShell (Windows).
# O PowerShell compila o codigo C# (arquivo .cs desta pasta) em memoria (Add-Type).
#
# Uso: powershell -NoProfile -ExecutionPolicy Bypass -File .\Iniciar-crud.ps1

if ($null -ne $IsWindows -and -not $IsWindows) {
    Write-Error "Este sistema funciona apenas no Windows."
    exit 1
}

try { [Console]::OutputEncoding = [System.Text.Encoding]::UTF8 } catch { }
try { $host.UI.RawUI.WindowTitle = "Inventario" } catch { }

# Procura o codigo-fonte (.cs) na pasta do script, qualquer que seja o nome
$fonte = Get-ChildItem -Path $PSScriptRoot -Filter *.cs | Select-Object -First 1
if (-not $fonte) {
    Write-Error "Nenhum arquivo .cs encontrado em: $PSScriptRoot"
    exit 1
}

if (-not ([System.Management.Automation.PSTypeName]'InventarioSistema').Type) {
    Add-Type -Path $fonte.FullName
}

[InventarioSistema]::PastaDados = $PSScriptRoot
[InventarioSistema]::Executar()
