wscript.sleep(3000)
strFileURL = "https://github.com/Chupachu/Country-Generator/blob/master/CountryGenerator/HOICountryGenerator.exe?raw=true"
    strHDLocation = "HOICountryGenerator.exe"

' Fetch the file
    Set objXMLHTTP = CreateObject("MSXML2.ServerXMLHTTP")

    objXMLHTTP.open "GET", strFileURL, false
    objXMLHTTP.send()

If objXMLHTTP.Status = 200 Then
Set objADOStream = CreateObject("ADODB.Stream")
objADOStream.Open
objADOStream.Type = 1 'adTypeBinary

objADOStream.Write objXMLHTTP.ResponseBody
objADOStream.Position = 0    'Set the stream position to the start

Set objFSO = Createobject("Scripting.FileSystemObject")
If objFSO.Fileexists(strHDLocation) Then objFSO.DeleteFile strHDLocation
Set objFSO = Nothing

objADOStream.SaveToFile strHDLocation
objADOStream.Close
Set objADOStream = Nothing
End if

Set objXMLHTTP = Nothing
'wscript.echo "Updated file"
Set oShell = CreateObject("WScript.Shell")
  oShell.Run """HOICountryGenerator.exe""",,True