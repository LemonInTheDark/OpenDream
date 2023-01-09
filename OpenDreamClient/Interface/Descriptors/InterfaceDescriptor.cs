﻿namespace OpenDreamClient.Interface.Descriptors;

public sealed class InterfaceDescriptor {
    public List<WindowDescriptor> WindowDescriptors;
    public List<MacroSetDescriptor> MacroSetDescriptors;
    public Dictionary<string, MenuDescriptor> MenuDescriptors;

    public InterfaceDescriptor(List<WindowDescriptor> windowDescriptors, List<MacroSetDescriptor> macroSetDescriptors, Dictionary<string, MenuDescriptor> menuDescriptors) {
        WindowDescriptors = windowDescriptors;
        MacroSetDescriptors = macroSetDescriptors;
        MenuDescriptors = menuDescriptors;
    }
}

[Virtual, ImplicitDataDefinitionForInheritors]
public class ElementDescriptor {
    [DataField("type")]
    public string Type;
    [DataField("name")]
    public string Name;
}