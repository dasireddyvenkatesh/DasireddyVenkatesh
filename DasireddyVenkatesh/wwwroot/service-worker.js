// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
self.addEventListener('install', event => event.waitUntil(self.skipWaiting()));
self.addEventListener('activate', event => event.waitUntil(onActivate()));
self.addEventListener('fetch', () => { });

async function onActivate() {
    const oldPublishedCaches = (await caches.keys())
        .filter(name => name.startsWith('offline-cache-'));

    // Development is network-only. Clear a published PWA cache if this origin
    // previously ran a release build, then move any open tabs to the dev build.
    await Promise.all(oldPublishedCaches.map(name => caches.delete(name)));
    await self.clients.claim();

    if (oldPublishedCaches.length > 0) {
        const windows = await self.clients.matchAll({ type: 'window', includeUncontrolled: true });
        await Promise.all(windows
            .filter(client => client.url.startsWith(self.registration.scope))
            .map(client => client.navigate(client.url)));
    }
}
