Add-Type -AssemblyName System.Windows.Forms
. (Join-Path $PSScriptRoot 'ff.designer.ps1')
$Form1.ShowDialog()