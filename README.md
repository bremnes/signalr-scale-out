# SignalR scale-out example

Example for scaling out signalr (asp.net core) on multiple front-end servers.

![](https://docs.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-in-signalr/_static/image2.png)[source](https://docs.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-in-signalr)

### TODO
- [x] Create quick example with asp.net core and SignalR. Use Redis as distribution mechanism for SignalR so that messages are distributed to all servers (and their browsers/clients) connected to the same backplane.
- [x] Add docker compose support.
- [ ] Add necessary Kubernetes files.
- [ ] Play around with and use [CoreUI](https://coreui.io/) as a theme for bootstrap. Explore notifications, sidetray etc.
- [ ] Test jenkins for build. Should include files for spinning up jenkins inside Kubernetes.
- [ ] Test Spinnaker for release process/management.

### Resources
- https://radu-matei.com/blog/signalr-core/