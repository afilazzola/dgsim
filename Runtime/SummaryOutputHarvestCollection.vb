﻿'*********************************************************************************************
' DG-Sim: A SyncroSim Module for simulating demographic population models.
'
' Copyright © 2007-2017 Apex Resource Management Solution Ltd. (ApexRMS). All rights reserved.
'
'*********************************************************************************************

Imports SyncroSim.Common
Imports System.Collections.ObjectModel

Friend Class SummaryOutputHarvestCollection
    Inherits KeyedCollection(Of ThreeIntegerLookupKey, SummaryOutputHarvest)

    Public Sub New()
        MyBase.New(New ThreeIntegerLookupKeyEqualityComparer)
    End Sub

    Protected Overrides Function GetKeyForItem(ByVal item As SummaryOutputHarvest) As ThreeIntegerLookupKey
        Return New ThreeIntegerLookupKey(item.StratumId, CInt(item.Sex), item.AgeClassId)
    End Function

End Class