'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace XamlStaticHelperNamespace
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")>  _
    Friend Class _XamlStaticHelper
        
        Private Shared schemaContextField As System.WeakReference
        
        Private Shared assemblyListField As System.Collections.Generic.IList(Of System.Reflection.[Assembly])
        
        Friend Shared ReadOnly Property SchemaContext() As System.Xaml.XamlSchemaContext
            Get
                Dim xsc As System.Xaml.XamlSchemaContext = Nothing
                If (Not (schemaContextField) Is Nothing) Then
                    xsc = CType(schemaContextField.Target,System.Xaml.XamlSchemaContext)
                    If (Not (xsc) Is Nothing) Then
                        Return xsc
                    End If
                End If
                If (AssemblyList.Count > 0) Then
                    xsc = New System.Xaml.XamlSchemaContext(AssemblyList)
                Else
                    xsc = New System.Xaml.XamlSchemaContext()
                End If
                schemaContextField = New System.WeakReference(xsc)
                Return xsc
            End Get
        End Property
        
        Friend Shared ReadOnly Property AssemblyList() As System.Collections.Generic.IList(Of System.Reflection.[Assembly])
            Get
                If (assemblyListField Is Nothing) Then
                    assemblyListField = LoadAssemblies
                End If
                Return assemblyListField
            End Get
        End Property
        
        Private Shared Function LoadAssemblies() As System.Collections.Generic.IList(Of System.Reflection.[Assembly])
            Dim assemblyList As System.Collections.Generic.IList(Of System.Reflection.[Assembly]) = New System.Collections.Generic.List(Of System.Reflection.[Assembly])()
            assemblyList.Add(Load("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System.Data.DataSetExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b"& _ 
                        "77a5c561934e089"))
            assemblyList.Add(Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50"& _ 
                        "a3a"))
            assemblyList.Add(Load("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"& _ 
                        ""))
            assemblyList.Add(Load("System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619"& _ 
                        "34e089"))
            assemblyList.Add(Load("System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(Load("System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08"& _ 
                        "9"))
            assemblyList.Add(Load("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"))
            assemblyList.Add(System.Reflection.Assembly.GetExecutingAssembly)
            Return assemblyList
        End Function
        
        Private Shared Function Load(ByVal assemblyNameVal As String) As System.Reflection.[Assembly]
            Dim assemblyName As System.Reflection.AssemblyName = New System.Reflection.AssemblyName(assemblyNameVal)
            Dim publicKeyToken() As Byte = assemblyName.GetPublicKeyToken
            Dim asm As System.Reflection.[Assembly] = Nothing
            Try 
                asm = System.Reflection.Assembly.Load(assemblyName.FullName)
            Catch __exception As System.Exception
                Dim shortName As System.Reflection.AssemblyName = New System.Reflection.AssemblyName(assemblyName.Name)
                If (Not (publicKeyToken) Is Nothing) Then
                    shortName.SetPublicKeyToken(publicKeyToken)
                End If
                asm = System.Reflection.Assembly.Load(shortName)
            End Try
            Return asm
        End Function
    End Class
End Namespace
