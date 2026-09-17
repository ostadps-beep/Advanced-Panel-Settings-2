[  ] private void PickColor(Action<string> setter)
[  ] {
[  ]     string selected = ColorPicker.Pick();
[  ]     if (selected != null)
[  ]     {
[  ]         setter(selected);
[  ]         OnPropertyChanged(nameof(Settings));
[  ]     }
[  ] }
[  ] 
[  ] private void SendToEngine(string key, object value)
[  ] {
[  ]     PythonBridge.Configure(
[  ]         Settings.Advanced.PythonBridge.Host,
[  ]         Settings.Advanced.PythonBridge.Port,
[  ]         Settings.Advanced.PythonBridge.Timeout
[  ]     );
[  ] 
[  ]     PythonBridge.Send(key, value);
[  ] }