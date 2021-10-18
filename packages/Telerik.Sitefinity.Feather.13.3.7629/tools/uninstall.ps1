param($installPath, $toolsPath, $package, $project)

 # This is the MSBuild targets file to add
    $targetsFile = [System.IO.Path]::Combine($toolsPath, 'RazorGenerator.MsBuild.targets')

    # Need to load MSBuild assembly if it's not loaded yet.
    Add-Type -AssemblyName 'Microsoft.Build, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
    # Grab the loaded MSBuild project for the project
    $msbuild = [Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection.GetLoadedProjects($project.FullName) | Select-Object -First 1
    $projPath = Split-Path $project.FileName;

    if(Test-Path (Join-Path $projPath "Build\RazorGenerator.MsBuild\build\RazorGenerator.MsBuild.targets")){
        # Add the import and save the project
        $msbuild.Xml.AddImport("Build\RazorGenerator.MsBuild\build\RazorGenerator.MsBuild.targets") | out-null
    }

    if(Test-Path (Join-Path $projPath "Build\FeatherPrecompilation.targets")){
        # Add the import and save the project
        $msbuild.Xml.AddImport("Build\FeatherPrecompilation.targets") | out-null
    }
    $project.Save()
	
	$assemblyInfoPath = Join-Path $projPath "Properties\AssemblyInfo.cs"
	if (Test-Path $assemblyInfoPath)
	{
		$assemblyInfoPathTemp = "$assemblyInfoPath.tmp"
		$controllerContainerRegex = "\[\s*assembly\s*\:\s*(?:(?:(?:(?:(?:(?:(?:Telerik\.)?Sitefinity\.)?Frontend\.)?Mvc\.)?Infrastructure\.)?Controllers\.)?Attributes\.)?ControllerContainer(?:Attribute)?\s*\]"
        $resourcePackageRegex = "\[\s*assembly\s*\:\s*(?:(?:(?:(?:(?:(?:(?:Telerik\.)?Sitefinity\.)?Frontend\.)?Mvc\.)?Infrastructure\.)?Controllers\.)?Attributes\.)?ResourcePackage(?:Attribute)?\s*\]"
		Get-Content $assemblyInfoPath | ? { $_ -notmatch $controllerContainerRegex } | ? { $_ -notmatch $resourcePackageRegex } | Set-Content $assemblyInfoPathTemp -Force
		Remove-Item $assemblyInfoPath
		Rename-Item $assemblyInfoPathTemp $assemblyInfoPath
	}

# SIG # Begin signature block
# MIImCwYJKoZIhvcNAQcCoIIl/DCCJfgCAQExCzAJBgUrDgMCGgUAMGkGCisGAQQB
# gjcCAQSgWzBZMDQGCisGAQQBgjcCAR4wJgIDAQAABBAfzDtgWUsITrck0sYpfvNR
# AgEAAgEAAgEAAgEAAgEAMCEwCQYFKw4DAhoFAAQU2LuZU3r8VEYWq5QzN3nCrPIJ
# 9iCggiE3MIIETjCCAzagAwIBAgINAe5fFp3/lzUrZGXWajANBgkqhkiG9w0BAQsF
# ADBXMQswCQYDVQQGEwJCRTEZMBcGA1UEChMQR2xvYmFsU2lnbiBudi1zYTEQMA4G
# A1UECxMHUm9vdCBDQTEbMBkGA1UEAxMSR2xvYmFsU2lnbiBSb290IENBMB4XDTE4
# MDkxOTAwMDAwMFoXDTI4MDEyODEyMDAwMFowTDEgMB4GA1UECxMXR2xvYmFsU2ln
# biBSb290IENBIC0gUjMxEzARBgNVBAoTCkdsb2JhbFNpZ24xEzARBgNVBAMTCkds
# b2JhbFNpZ24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDMJXaQeQZ4
# Ihb1wIO2hMoonv0FdhHFrYhy/EYCQ8eyip0EXyTLLkvhYIJG4VKrDIFHcGzdZNHr
# 9SyjD4I9DCuul9e2FIYQebs7E4B3jAjhSdJqYi8fXvqWaN+JJ5U4nwbXPsnLJlkN
# c96wyOkmDoMVxu9bi9IEYMpJpij2aTv2y8gokeWdimFXN6x0FNx04Druci8unPvQ
# u7/1PQDhBjPogiuuU6Y6FnOM3UEOIDrAtKeh6bJPkC4yYOlXy7kEkmho5TgmYHWy
# n3f/kRTvriBJ/K1AFUjRAjFhGV64l++td7dkmnq/X8ET75ti+w1s4FRpFqkD2m7p
# g5NxdsZphYIXAgMBAAGjggEiMIIBHjAOBgNVHQ8BAf8EBAMCAQYwDwYDVR0TAQH/
# BAUwAwEB/zAdBgNVHQ4EFgQUj/BLf6guRSSuTVD6Y5qL3uLdG7wwHwYDVR0jBBgw
# FoAUYHtmGkUNl8qJUC99BM00qP/8/UswPQYIKwYBBQUHAQEEMTAvMC0GCCsGAQUF
# BzABhiFodHRwOi8vb2NzcC5nbG9iYWxzaWduLmNvbS9yb290cjEwMwYDVR0fBCww
# KjAooCagJIYiaHR0cDovL2NybC5nbG9iYWxzaWduLmNvbS9yb290LmNybDBHBgNV
# HSAEQDA+MDwGBFUdIAAwNDAyBggrBgEFBQcCARYmaHR0cHM6Ly93d3cuZ2xvYmFs
# c2lnbi5jb20vcmVwb3NpdG9yeS8wDQYJKoZIhvcNAQELBQADggEBACNw6c/ivvVZ
# rpRCb8RDM6rNPzq5ZBfyYgZLSPFAiAYXof6r0V88xjPy847dHx0+zBpgmYILrMf8
# fpqHKqV9D6ZX7qw7aoXW3r1AY/itpsiIsBL89kHfDwmXHjjqU5++BfQ+6tOfUBJ2
# vgmLwgtIfR4uUfaNU9OrH0Abio7tfftPeVZwXwzTjhuzp3ANNyuXlava4BJrHEDO
# xcd+7cJiWOx37XMiwor1hkOIreoTbv3Y/kIvuX1erRjvlJDKPSerJpSZdcfL03v3
# ykzTr1EhkluEfSufFT90y1HonoMOFm8b50bOI7355KKL0jlrqnkckSziYSQtjipI
# cJDEHsXo4HAwggT+MIID5qADAgECAhANQkrgvjqI/2BAIc4UAPDdMA0GCSqGSIb3
# DQEBCwUAMHIxCzAJBgNVBAYTAlVTMRUwEwYDVQQKEwxEaWdpQ2VydCBJbmMxGTAX
# BgNVBAsTEHd3dy5kaWdpY2VydC5jb20xMTAvBgNVBAMTKERpZ2lDZXJ0IFNIQTIg
# QXNzdXJlZCBJRCBUaW1lc3RhbXBpbmcgQ0EwHhcNMjEwMTAxMDAwMDAwWhcNMzEw
# MTA2MDAwMDAwWjBIMQswCQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNlcnQsIElu
# Yy4xIDAeBgNVBAMTF0RpZ2lDZXJ0IFRpbWVzdGFtcCAyMDIxMIIBIjANBgkqhkiG
# 9w0BAQEFAAOCAQ8AMIIBCgKCAQEAwuZhhGfFivUNCKRFymNrUdc6EUK9CnV1TZS0
# DFC1JhD+HchvkWsMlucaXEjvROW/m2HNFZFiWrj/ZwucY/02aoH6KfjdK3CF3gIY
# 83htvH35x20JPb5qdofpir34hF0edsnkxnZ2OlPR0dNaNo/Go+EvGzq3YdZz7E5t
# M4p8XUUtS7FQ5kE6N1aG3JMjjfdQJehk5t3Tjy9XtYcg6w6OLNUj2vRNeEbjA4Mx
# KUpcDDGKSoyIxfcwWvkUrxVfbENJCf0mI1P2jWPoGqtbsR0wwptpgrTb/FZUvB+h
# h6u+elsKIC9LCcmVp42y+tZji06lchzun3oBc/gZ1v4NSYS9AQIDAQABo4IBuDCC
# AbQwDgYDVR0PAQH/BAQDAgeAMAwGA1UdEwEB/wQCMAAwFgYDVR0lAQH/BAwwCgYI
# KwYBBQUHAwgwQQYDVR0gBDowODA2BglghkgBhv1sBwEwKTAnBggrBgEFBQcCARYb
# aHR0cDovL3d3dy5kaWdpY2VydC5jb20vQ1BTMB8GA1UdIwQYMBaAFPS24SAd/imu
# 0uRhpbKiJbLIFzVuMB0GA1UdDgQWBBQ2RIaOpLqwZr68KC0dRDbd42p6vDBxBgNV
# HR8EajBoMDKgMKAuhixodHRwOi8vY3JsMy5kaWdpY2VydC5jb20vc2hhMi1hc3N1
# cmVkLXRzLmNybDAyoDCgLoYsaHR0cDovL2NybDQuZGlnaWNlcnQuY29tL3NoYTIt
# YXNzdXJlZC10cy5jcmwwgYUGCCsGAQUFBwEBBHkwdzAkBggrBgEFBQcwAYYYaHR0
# cDovL29jc3AuZGlnaWNlcnQuY29tME8GCCsGAQUFBzAChkNodHRwOi8vY2FjZXJ0
# cy5kaWdpY2VydC5jb20vRGlnaUNlcnRTSEEyQXNzdXJlZElEVGltZXN0YW1waW5n
# Q0EuY3J0MA0GCSqGSIb3DQEBCwUAA4IBAQBIHNy16ZojvOca5yAOjmdG/UJyUXQK
# I0ejq5LSJcRwWb4UoOUngaVNFBUZB3nw0QTDhtk7vf5EAmZN7WmkD/a4cM9i6PVR
# Snh5Nnont/PnUp+Tp+1DnnvntN1BIon7h6JGA0789P63ZHdjXyNSaYOC+hpT7ZDM
# jaEXcw3082U5cEvznNZ6e9oMvD0y0BvL9WH8dQgAdryBDvjA4VzPxBFy5xtkSdgi
# mnUVQvUtMjiB2vRgorq0Uvtc4GEkJU+y38kpqHNDUdq9Y9YfW5v3LhtPEx33Sg1x
# fpe39D+E68Hjo0mh+s6nv1bPull2YYlffqe0jmd4+TaY4cso2luHpoovMIIFMTCC
# BBmgAwIBAgIQCqEl1tYyG35B5AXaNpfCFTANBgkqhkiG9w0BAQsFADBlMQswCQYD
# VQQGEwJVUzEVMBMGA1UEChMMRGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3d3cuZGln
# aWNlcnQuY29tMSQwIgYDVQQDExtEaWdpQ2VydCBBc3N1cmVkIElEIFJvb3QgQ0Ew
# HhcNMTYwMTA3MTIwMDAwWhcNMzEwMTA3MTIwMDAwWjByMQswCQYDVQQGEwJVUzEV
# MBMGA1UEChMMRGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3d3cuZGlnaWNlcnQuY29t
# MTEwLwYDVQQDEyhEaWdpQ2VydCBTSEEyIEFzc3VyZWQgSUQgVGltZXN0YW1waW5n
# IENBMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvdAy7kvNj3/dqbqC
# mcU5VChXtiNKxA4HRTNREH3Q+X1NaH7ntqD0jbOI5Je/YyGQmL8TvFfTw+F+CNZq
# FAA49y4eO+7MpvYyWf5fZT/gm+vjRkcGGlV+Cyd+wKL1oODeIj8O/36V+/OjuiI+
# GKwR5PCZA207hXwJ0+5dyJoLVOOoCXFr4M8iEA91z3FyTgqt30A6XLdR4aF5FMZN
# JCMwXbzsPGBqrC8HzP3w6kfZiFBe/WZuVmEnKYmEUeaC50ZQ/ZQqLKfkdT66mA+E
# f58xFNat1fJky3seBdCEGXIX8RcG7z3N1k3vBkL9olMqT4UdxB08r8/arBD13ays
# 6Vb/kwIDAQABo4IBzjCCAcowHQYDVR0OBBYEFPS24SAd/imu0uRhpbKiJbLIFzVu
# MB8GA1UdIwQYMBaAFEXroq/0ksuCMS1Ri6enIZ3zbcgPMBIGA1UdEwEB/wQIMAYB
# Af8CAQAwDgYDVR0PAQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUFBwMIMHkGCCsG
# AQUFBwEBBG0wazAkBggrBgEFBQcwAYYYaHR0cDovL29jc3AuZGlnaWNlcnQuY29t
# MEMGCCsGAQUFBzAChjdodHRwOi8vY2FjZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNl
# cnRBc3N1cmVkSURSb290Q0EuY3J0MIGBBgNVHR8EejB4MDqgOKA2hjRodHRwOi8v
# Y3JsNC5kaWdpY2VydC5jb20vRGlnaUNlcnRBc3N1cmVkSURSb290Q0EuY3JsMDqg
# OKA2hjRodHRwOi8vY3JsMy5kaWdpY2VydC5jb20vRGlnaUNlcnRBc3N1cmVkSURS
# b290Q0EuY3JsMFAGA1UdIARJMEcwOAYKYIZIAYb9bAACBDAqMCgGCCsGAQUFBwIB
# FhxodHRwczovL3d3dy5kaWdpY2VydC5jb20vQ1BTMAsGCWCGSAGG/WwHATANBgkq
# hkiG9w0BAQsFAAOCAQEAcZUS6VGHVmnN793afKpjerN4zwY3QITvS4S/ys8DAv3F
# p8MOIEIsr3fzKx8MIVoqtwU0HWqumfgnoma/Capg33akOpMP+LLR2HwZYuhegiUe
# xLoceywh4tZbLBQ1QwRostt1AuByx5jWPGTlH0gQGF+JOGFNYkYkh2OMkVIsrymJ
# 5Xgf1gsUpYDXEkdws3XVk4WTfraSZ/tTYYmo9WuWwPRYaQ18yAGxuSh1t5ljhSKM
# Ycp5lH5Z/IwP42+1ASa2bKXuh1Eh5Fhgm7oMLSttosR+u8QlK0cCCHxJrhO24XxC
# QijGGFbPQTS2Zl22dHv1VjMiLyI2skuiSpXY9aaOUjCCBaIwggSKoAMCAQICEHgD
# GEJFcIpBz28BuO60qVQwDQYJKoZIhvcNAQEMBQAwTDEgMB4GA1UECxMXR2xvYmFs
# U2lnbiBSb290IENBIC0gUjMxEzARBgNVBAoTCkdsb2JhbFNpZ24xEzARBgNVBAMT
# Ckdsb2JhbFNpZ24wHhcNMjAwNzI4MDAwMDAwWhcNMjkwMzE4MDAwMDAwWjBTMQsw
# CQYDVQQGEwJCRTEZMBcGA1UEChMQR2xvYmFsU2lnbiBudi1zYTEpMCcGA1UEAxMg
# R2xvYmFsU2lnbiBDb2RlIFNpZ25pbmcgUm9vdCBSNDUwggIiMA0GCSqGSIb3DQEB
# AQUAA4ICDwAwggIKAoICAQC2LcUw3Xroq5A9A3KwOkuZFmGy5f+lZx03HOV+7JOD
# qoT1o0ObmEWKuGNXXZsAiAQl6fhokkuC2EvJSgPzqH9qj4phJ72hRND99T8iwqNP
# kY2zBbIogpFd+1mIBQuXBsKY+CynMyTuUDpBzPCgsHsdTdKoWDiW6d/5G5G7ixAs
# 0sdDHaIJdKGAr3vmMwoMWWuOvPSrWpd7f65V+4TwgP6ETNfiur3EdaFvvWEQdESy
# mAfidKv/aNxsJj7pH+XgBIetMNMMjQN8VbgWcFwkeCAl62dniKu6TjSYa3AR3jjK
# 1L6hwJzh3x4CAdg74WdDhLbP/HS3L4Sjv7oJNz1nbLFFXBlhq0GD9awd63cNRkdz
# zr+9lZXtnSuIEP76WOinV+Gzz6ha6QclmxLEnoByPZPcjJTfO0TmJoD80sMD8IwM
# 0kXWLuePmJ7mBO5Cbmd+QhZxYucE+WDGZKG2nIEhTivGbWiUhsaZdHNnMXqR8tSM
# eW58prt+Rm9NxYUSK8+aIkQIqIU3zgdhVwYXEiTAxDFzoZg1V0d+EDpF2S2kUZCY
# qaAHN8RlGqocaxZ396eX7D8ZMJlvMfvqQLLn0sT6ydDwUHZ0WfqNbRcyvvjpfgP0
# 54d1mtRKkSyFAxMCK0KA8olqNs/ITKDOnvjLja0Wp9Pe1ZsYp8aSOvGCY/EuDiRk
# 3wIDAQABo4IBdzCCAXMwDgYDVR0PAQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUF
# BwMDMA8GA1UdEwEB/wQFMAMBAf8wHQYDVR0OBBYEFB8Av0aACvx4ObeltEPZVlC7
# zpY7MB8GA1UdIwQYMBaAFI/wS3+oLkUkrk1Q+mOai97i3Ru8MHoGCCsGAQUFBwEB
# BG4wbDAtBggrBgEFBQcwAYYhaHR0cDovL29jc3AuZ2xvYmFsc2lnbi5jb20vcm9v
# dHIzMDsGCCsGAQUFBzAChi9odHRwOi8vc2VjdXJlLmdsb2JhbHNpZ24uY29tL2Nh
# Y2VydC9yb290LXIzLmNydDA2BgNVHR8ELzAtMCugKaAnhiVodHRwOi8vY3JsLmds
# b2JhbHNpZ24uY29tL3Jvb3QtcjMuY3JsMEcGA1UdIARAMD4wPAYEVR0gADA0MDIG
# CCsGAQUFBwIBFiZodHRwczovL3d3dy5nbG9iYWxzaWduLmNvbS9yZXBvc2l0b3J5
# LzANBgkqhkiG9w0BAQwFAAOCAQEArPfMFYsweagdCyiIGQnXHH/+hr17WjNuDWcO
# e2LZ4RhcsL0TXR0jrjlQdjeqRP1fASNZhlZMzK28ZBMUMKQgqOA/6Jxy3H7z2Awj
# uqgtqjz27J+HMQdl9TmnUYJ14fIvl/bR4WWWg2T+oR1R+7Ukm/XSd2m8hSxc+lh3
# 0a6nsQvi1ne7qbQ0SqlvPfTzDZVd5vl6RbAlFzEu2/cPaOaDH6n35dSdmIzTYUsv
# wyh+et6TDrR9oAptksS0Zj99p1jurPfswwgBqzj8ChypxZeyiMgJAhn2XJoa8U1s
# MNSzBqsAYEgNeKvPF62Sk2Igd3VsvcgytNxN69nfwZCWKb3BfzCCBhowggQCoAMC
# AQICDHd7A4Za2Ub5hkmzojANBgkqhkiG9w0BAQsFADBZMQswCQYDVQQGEwJCRTEZ
# MBcGA1UEChMQR2xvYmFsU2lnbiBudi1zYTEvMC0GA1UEAxMmR2xvYmFsU2lnbiBH
# Q0MgUjQ1IENvZGVTaWduaW5nIENBIDIwMjAwHhcNMjEwNDA4MTcyMjA3WhcNMjIw
# MTA5MTkyMDM1WjCBhzELMAkGA1UEBhMCVVMxFjAUBgNVBAgTDU1hc3NhY2h1c2V0
# dHMxEDAOBgNVBAcTB0JlZGZvcmQxJjAkBgNVBAoTHVByb2dyZXNzIFNvZnR3YXJl
# IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1Qcm9ncmVzcyBTb2Z0d2FyZSBDb3Jwb3Jh
# dGlvbjCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBANfOuCWV7EszvyGW
# 5LI/HmxwzgLAOVZxEP2ishyVt9K9Zz6RDt6l4h9EBpRJ7LcE+CATFbYlbUGm9jqK
# tyQr7EoEO9sdSJrt9srhN8yE9B9cejFS88dVhdrtr6Zt9nFbo5VNpY3IY6i7nh12
# V96Qq5eAQ3z6RSfpAggkETRaGFrElNq5ovovmVG89wSEB7imPADKziVaz7eBFnQI
# h1Ru2ACwOX22WlnqqErmKuvGK92W18B3Tq1z5GzCdUGFCSaY/ftbvCg7zJz73TWj
# pgHBRD/YQ3wjMAibjO32JNlzyGLVTx4MRmeyhrnVipzSeGurbeu6QLFjgv7mnozO
# 97FNvrkCAwEAAaOCAbEwggGtMA4GA1UdDwEB/wQEAwIHgDCBmwYIKwYBBQUHAQEE
# gY4wgYswSgYIKwYBBQUHMAKGPmh0dHA6Ly9zZWN1cmUuZ2xvYmFsc2lnbi5jb20v
# Y2FjZXJ0L2dzZ2NjcjQ1Y29kZXNpZ25jYTIwMjAuY3J0MD0GCCsGAQUFBzABhjFo
# dHRwOi8vb2NzcC5nbG9iYWxzaWduLmNvbS9nc2djY3I0NWNvZGVzaWduY2EyMDIw
# MFYGA1UdIARPME0wQQYJKwYBBAGgMgEyMDQwMgYIKwYBBQUHAgEWJmh0dHBzOi8v
# d3d3Lmdsb2JhbHNpZ24uY29tL3JlcG9zaXRvcnkvMAgGBmeBDAEEATAJBgNVHRME
# AjAAMEUGA1UdHwQ+MDwwOqA4oDaGNGh0dHA6Ly9jcmwuZ2xvYmFsc2lnbi5jb20v
# Z3NnY2NyNDVjb2Rlc2lnbmNhMjAyMC5jcmwwEwYDVR0lBAwwCgYIKwYBBQUHAwMw
# HwYDVR0jBBgwFoAU2rONwCSQo2t30wygWd0hZ2R2C3gwHQYDVR0OBBYEFC3HCjFv
# PjVuTmcvKGHO4xw3KRJ8MA0GCSqGSIb3DQEBCwUAA4ICAQCvsReFUfNwmzuCE0+A
# kwEmC8kvPgHGx3ZkV/BKBbqGriY3cnFl4tAA48YIlLZayEWmGFH4jTHoaUSWQtyl
# 7+KW5C7eaRhkIjVvFqFV9peBuM0PU5ld8OF8gRpydoIXsP8wXKwS/fMrulUxPmiA
# dN7KNSs2bMb2fCE7YcB+gjooDnaxgMXR7Io9aGS4VX+zLzLxT7ATyrSWgjnXzm0+
# OnTRLtK47J4YosEr9oNMiO697mZybWEY5J+DjVLoS8Gq7ZEEBGT7MbBJBu39UP0h
# NWVt8W7a1SGBcsePYWE+1Z1/LH2y6QoF9f0qmum/utZu0UrHK0l4g02fCeLbWPB3
# P42FJJi0tGbvpUrsYJGIDgPw/qicuK5kjVQuo4uFf90CxiAKJpHGcSPyslYDdDXt
# Z1nt6Bo2hu8dode8cEUb5+g0VINqbGYaCvLyeVEytK/yehGpRvTstCjTVFhHgoIq
# hfMUYQ0TmNzXlPpm8zWq93Qof/oZSiCmy6QK8q1Fjhuj95bOnUvje8qmbaEXz/GD
# +HYQu/JbBPfXFPF3xTh8vx0At+VtbQd4YBSLT8l1lJiSaGIo8PBIPMEtK43fFN0Y
# wN3iFlPrKCrOnDACmQm86PTKuf38Ea5nvYiFCjq1M3W5UpAblHD1NBJoRREokSY7
# eoJfuw9K9fLlNrarN5i1OnwzNjCCBuYwggTOoAMCAQICEHe9DgOhtwj4VKsGchDZ
# BEcwDQYJKoZIhvcNAQELBQAwUzELMAkGA1UEBhMCQkUxGTAXBgNVBAoTEEdsb2Jh
# bFNpZ24gbnYtc2ExKTAnBgNVBAMTIEdsb2JhbFNpZ24gQ29kZSBTaWduaW5nIFJv
# b3QgUjQ1MB4XDTIwMDcyODAwMDAwMFoXDTMwMDcyODAwMDAwMFowWTELMAkGA1UE
# BhMCQkUxGTAXBgNVBAoTEEdsb2JhbFNpZ24gbnYtc2ExLzAtBgNVBAMTJkdsb2Jh
# bFNpZ24gR0NDIFI0NSBDb2RlU2lnbmluZyBDQSAyMDIwMIICIjANBgkqhkiG9w0B
# AQEFAAOCAg8AMIICCgKCAgEA1kJN+eNPxiP0bB2BpjD3SD3P0OWN5SAilgdENV0G
# zw8dcGDmJlT6UyNgAqhfAgL3jsluPal4Bb2O9U8ZJJl8zxEWmx97a9Kje2hld6vY
# sSw/03IGMlxbrFBnLCVNVgY2/MFiTH19hhaVml1UulDQsH+iRBnp1m5sPhPCnxHU
# XzRbUWgxYwr4W9DeullfMa+JaDhAPgjoU2dOY7Yhju/djYVBVZ4cvDfclaDEcacf
# G6VJbgogWX6Jo1gVlwAlad/ewmpQZU5T+2uhnxgeig5fVF694FvP8gwE0t4IoRAm
# 97Lzei7CjpbBP86l2vRZKIw3ZaExlguOpHZ3FUmEZoIl50MKd1KxmVFC/6Gy3ZzS
# 3BjZwYapQB1Bl2KGvKj/osdjFwb9Zno2lAEgiXgfkPR7qVJOak9UBiqAr57HUEL6
# ZQrjAfSxbqwOqOOBGag4yJ4DKIakdKdHlX5yWip7FWocxGnmsL5AGZnL0n1VTiKc
# EOChW8OzLnqLxN7xSx+MKHkwRX9sE7Y9LP8tSooq7CgPLcrUnJiKSm1aNiwv37rL
# 4kFKCHcYiK01YZQS86Ry6+42nqdRJ5E896IazPyH5ZfhUYdp6SLMg8C3D0VsB+FD
# T9SMSs7PY7G1pBB6+Q0MKLBrNP4haCdv7Pj6JoRbdULNiSZ5WZ1rq2NxYpAlDQgg
# 8f8CAwEAAaOCAa4wggGqMA4GA1UdDwEB/wQEAwIBhjATBgNVHSUEDDAKBggrBgEF
# BQcDAzASBgNVHRMBAf8ECDAGAQH/AgEAMB0GA1UdDgQWBBTas43AJJCja3fTDKBZ
# 3SFnZHYLeDAfBgNVHSMEGDAWgBQfAL9GgAr8eDm3pbRD2VZQu86WOzCBkwYIKwYB
# BQUHAQEEgYYwgYMwOQYIKwYBBQUHMAGGLWh0dHA6Ly9vY3NwLmdsb2JhbHNpZ24u
# Y29tL2NvZGVzaWduaW5ncm9vdHI0NTBGBggrBgEFBQcwAoY6aHR0cDovL3NlY3Vy
# ZS5nbG9iYWxzaWduLmNvbS9jYWNlcnQvY29kZXNpZ25pbmdyb290cjQ1LmNydDBB
# BgNVHR8EOjA4MDagNKAyhjBodHRwOi8vY3JsLmdsb2JhbHNpZ24uY29tL2NvZGVz
# aWduaW5ncm9vdHI0NS5jcmwwVgYDVR0gBE8wTTBBBgkrBgEEAaAyATIwNDAyBggr
# BgEFBQcCARYmaHR0cHM6Ly93d3cuZ2xvYmFsc2lnbi5jb20vcmVwb3NpdG9yeS8w
# CAYGZ4EMAQQBMA0GCSqGSIb3DQEBCwUAA4ICAQAIiHImxq/6rF8GwKqMkNrQssCi
# l/9uEzIWVP0+9DARn4+Y+ZtS3fKiFu7ZeJWmmnxhuAS1+OvL9GERM/ZlJbcRQovY
# aW7H/5W0gUOpfq6/gtZNzBGjg3FqEF4ZBafnbH9W9Khcw04JrVlruPl+pS64/N4O
# wqD7sATUExvHJ6m5qi0xO89GTJ3rTOy8Lpzxh6N/OGlfQUBn9lN96kHvjj37qdQR
# OEbfPOv2zSK9E83w4eblM6C+POR41RvMIPIwc7AiHPaE1ptcAALhKFJL/xJLQOru
# sBoGBp6E5ufw24RG+3PZK0K2yVc0xxbApushuaoO9/7byuu8F8u4Z+vjPk/bqZSG
# ZFXJCQrA2QRxShFLWmTDvHh4rUxHJmUHmdXNNmChM1Oz9nsq1YlAPHGlq/iZWf3j
# m5JL3QW9Cwx4BivPU9i9EppbJ4aFP5G+4HiAc1Tfpx1nK2q2rk2JgCQIUnBQ8wH/
# RK4vmuDhSQjh4VvXONGeCoqdlCebyqO52+I2auNvuVhi4DZ4NgH6waeJeiZTo1y7
# 0rLristjCC/+HvNWKeI1m9j/6aW9bUtZLIksL1K7tSmQ2kNHvHLdvNm/gMHcsKu0
# Sx1YNjdk65vhhReaKaL95gjSkv+g+Hzh6afRMI5fJlArx6Lil3eK79hNPibrmUBg
# 8zxnDLYIcik1U4E03DGCBD4wggQ6AgEBMGkwWTELMAkGA1UEBhMCQkUxGTAXBgNV
# BAoTEEdsb2JhbFNpZ24gbnYtc2ExLzAtBgNVBAMTJkdsb2JhbFNpZ24gR0NDIFI0
# NSBDb2RlU2lnbmluZyBDQSAyMDIwAgx3ewOGWtlG+YZJs6IwCQYFKw4DAhoFAKB4
# MBgGCisGAQQBgjcCAQwxCjAIoAKAAKECgAAwGQYJKoZIhvcNAQkDMQwGCisGAQQB
# gjcCAQQwHAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwIwYJKoZIhvcNAQkE
# MRYEFOLkqi0ApLzcCov6jpi2OKoORWrDMA0GCSqGSIb3DQEBAQUABIIBAAj4NyTn
# zsUh0Y4JsddK1zHsYYtfy6eWg2Zz5x8OQM3/8XV+NxMGLX7s+vGuFIkyoDt0Yc+y
# HOoVSZ2M/g3PkYj/YQrGYPqJLk5YVXUzq8dqHfacXBJe3Ej1Dybbp9XkAaPa7sHs
# m2ap7crgEk4K5qkkoWJkGUtKIB7W3jgGfLY2K0B7hFViiZB062ojjwimM+ZGFSfm
# N3ePEALMpyfQGjCtvNF6+o4fhbu9r7Y0FdcueY0JaI/R4hau+xj6ShOtavLlMhOk
# f0jXf1oL7RW7NypeLw49ic8nFDwnsCdWquMNsH2gLa9RTcnHr/sX7qc16ITTJuvR
# VEvZWqwayHw1OBqhggIwMIICLAYJKoZIhvcNAQkGMYICHTCCAhkCAQEwgYYwcjEL
# MAkGA1UEBhMCVVMxFTATBgNVBAoTDERpZ2lDZXJ0IEluYzEZMBcGA1UECxMQd3d3
# LmRpZ2ljZXJ0LmNvbTExMC8GA1UEAxMoRGlnaUNlcnQgU0hBMiBBc3N1cmVkIElE
# IFRpbWVzdGFtcGluZyBDQQIQDUJK4L46iP9gQCHOFADw3TANBglghkgBZQMEAgEF
# AKBpMBgGCSqGSIb3DQEJAzELBgkqhkiG9w0BBwEwHAYJKoZIhvcNAQkFMQ8XDTIx
# MDcyOTEyMjkyNVowLwYJKoZIhvcNAQkEMSIEIK1NLPsKKvgeOHdwF6D7xp/9BnKf
# NkqGM1M3YYaU5+I1MA0GCSqGSIb3DQEBAQUABIIBAAC078ugbtIsemUhMbcvNu79
# 6/9q2kyvorCdlohDGn/3bH+zXqjU+rRrzNdhXoc3grmV5vSQB9x0tJv+Q9u+cAko
# B+pfkYvNLtpEaI+0Mn5fb/V3AZFFgBeqOhAfJHmc3vq7LvcrpUQZTTcw+Ex95jUX
# Cx/dMhScvwXU8oP2nVAAwEahIaiEVhPERNxxk67ewYMTYtuGstyrRUKkcDzbfGYv
# /R141B0t37QBZ72twapMOrozU352amhKCFFRaQgirss6rHDxfuH2s8apbr8lLEoc
# R0keqV5sIVBpTX/z28Ly7KHvJY+3hOiRc97xo2XNMsTL2c32f0wxAJJfEJWrh/A=
# SIG # End signature block
