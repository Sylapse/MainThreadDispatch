# MainThreadDispatch

A helper for MvvmLight to ensure that RaisePropertyChanged is called on the UI thread. Similar to DispatcherHelper but intended for PCL projects.

In your view models, instead of using these usual Set methods.

```
Set (() => MyProperty, ref _myProperty, value)
Set ("MyProperty", ref _myProperty, value)
Set (ref _myProperty, value)
```

Add `using Sylapse.MainThreadDispatch;` and use the following extension methods.

```
this.DispatchSet (() => MyProperty, ref _myProperty, value)
this.DispatchSet ("MyProperty", ref _myProperty, value)
this.DispatchSet (ref _myProperty, value)
```

If you just want to execute some code on the UI thread then use

```
this.Dispatch (() => {
    // Code to execute on the UI thread
});
```

To execute code on the UI thread from a PCL but outside of a ViewModel class use

```
MainThreadDispatcher.Instance.Execute (() => {
    // Code to execute on the UI thread
});
```

## Nuget

https://www.nuget.org/packages/Sylapse.MainThreadDispatch

Add MainThreadDispatch to your PCL and platform projects. Currently supported platforms are:

- Xamarin.Android
- Xamarin.iOS
- UWP
- .Net 4.5 (just executes on the current thread, mainly for unit test projects)
