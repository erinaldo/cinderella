﻿Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ICliente" in both code and config file together.
<ServiceContract()>
Public Interface ICliente

    <OperationContract()>
    Function GetClienteMayorista(ByVal RazonSocial As String) As List(Of EntidadClientes)

End Interface
