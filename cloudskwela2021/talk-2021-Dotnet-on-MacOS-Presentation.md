---

marp: true

---

# PHINUG 2021.07

![bg opacity](https://firebasestorage.googleapis.com/v0/b/firescript-577a2.appspot.com/o/imgs%2Fapp%2Fmjtpena%2FlrQaXNR02y.jpg?alt=media&token=e85c46d1-1135-467b-ab6b-ea70646529b1)

##### **The State of .NET on Mac OS** __<!--fit-->__

###### by Michael John Peña

---

# About Me

![bg right](https://firebasestorage.googleapis.com/v0/b/firescript-577a2.appspot.com/o/imgs%2Fapp%2Fmjtpena%2FbmeQUggVCZ.jpg?alt=media&token=e160606c-49b6-41ef-80c3-1b2e019a770a)

Director @ [Datachain Consulting][Datachain Website]

Microsoft Azure MVP (former Windows Dev Tech MVP)

Co-Author of Cloud Analytics with Microsoft Azure

Loves all things: .NET, Blockchain, Web, Mobile, Cloud, ML, IoT, and Data.

---

# Agenda

:memo: Nomenclature and Definition of Terms

:vs: Different toolsets and IDE

:t-rex: Mono and .NET

:desktop_computer: Xamarin.Mac and Xamarin.Forms

:spider_web: .NET 5 (ASPNET Core and Worker Service)

:rocket: .NET 6, Mac Catalyst, and MAUI

---

# Mono

Started by Miguel de Icaza (GNOME, Novell, Xamarin, Microsoft)

Mono is an open source implementation of Microsoft's .NET Framework based on the [ECMA](https://www.mono-project.com/docs/about-mono/languages/ecma/) standards for [C#](https://www.mono-project.com/docs/about-mono/languages/csharp/) and the [Common Language Runtime](https://www.mono-project.com/docs/advanced/runtime/).

Enabled .NET apps (before .NET Core) to run on MacOS, Linux, and mobile operating systems such as Android, iOS, and Tizen. 

The roots of what's now called Xamarin.

---

# Demo #1 : Mono and .NET

---

# Xamarin.Mac

Started as MonoMac.

Native bindings of Mac OS APIs exposed via C#

Works with Cocoa library features: ".storyboard" / ".xib"

Follows the same native principles: AppDelegate, Main, Entitlements, Plist 

Uses XCode to bundle the ".app"

---

# Xamarin.Forms

Cross Platform UI Framework: MacOS, iOS, Android and Windows

Create native components using XAML / C# / F#

The Xamarin.Mac project references Xamarin.Forms project

Can invoke platform specific methods

Applies conventions like MVVM (Model-View-ViewModel)

---

# Demo #2: Xamarin.Mac and Xamarin.Forms

---

# .NET 5 (Core)

General purpose framework to build apps targeting Windows, Linux, and MacOS

What works on Mac: 

ASPNET Family (Blazor, API, gRPC, React, Angular, Vue, etc) 

Console apps & worker services 

Machine Learning, IoT, Docker

On MacOS, it doesn't interface with Cocoa or rich native libraries

You can invoke some System variables and call command line such as Airport

---

# Demo #3: .NET 5 (Web and Worker Service)

---

# Mac Catalyst

Shared SDK codes between Mac OS and iPad OS (not iOS)

Unified components like pop-up buttons, tooltips, window's sidebar

Unified GameKit, PassKit, MediaPlyer, Core Audio, Core Bluetooth, etc

Requires XCode 13 on Big Sur / Monterey

---

# .NET 6 + MAUI (and beyond)

More shared libraries across Xamarin/Mono and .NET Framework family

Introduced the concept of `workload`

`dotnet workload install microsoft-macos-sdk-full`

`dotnet workload install microsoft-maccatalyst-sdk-full`

`dotnet workload install maui-maccatalyst`

Xamarin.Mac => Microsoft-MacOS

Xamarin.MaciOS + Mac Catalyst => Microsoft-MacCatalst

Xamarin.Forms + UWP => **MAUI**

![h:311 w:441 bg right](https://docs.microsoft.com/en-us/dotnet/maui/what-is-maui-images/maui.png)

---

# Demo #4: .NET 6, Mac Catalyst, and MAUI

---

# Resources

[mjtpena/Mac.NET.Samples](https://github.com/mjtpena/Mac.NET.Samples)

[Mac Catalyst Overview - Apple Developer](https://developer.apple.com/mac-catalyst/)

[.NET Blog (microsoft.com)](https://devblogs.microsoft.com/dotnet/)

[dotnet/maui-samples](https://github.com/dotnet/maui-samples)

[Mono Project](https://www.mono-project.com/)

---

**Thank you for watching! :v: **__<!--fit-->__

###### michael@datachain.consulting

###### https://michaeljohnpena.com

###### [@mjtpena / Twitter](https://twitter.com/mjtpena)

###### [LinkedIn](https://www.linkedin.com/in/michaeljohnpena/)

---

[Datachain Website]: https://datachain.consulting
