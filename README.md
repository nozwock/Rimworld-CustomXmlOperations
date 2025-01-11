# Custom XML Operations

For now, the repo only contains an operation for string splitting in Rimworld XML patches.

### GetSplit
```xml
<!-- Separator is hardocoded `~`, as I didn't have a need for any other -->
<Operation Class="XmlGetSplit.GetSplit">
    <xpath>Defs/ThingDef[@ParentName="BuildingBase" and thingCategories[li="BuildingsJoy"]]/building[joyKind="Television"]/watchBuildingStandDistanceRange</xpath>
    <storeTo>Defs/XmlExtensions.SlateDef[@Name="SlateName"]/StoreToThisElement</storeTo>
</Operation>
```
