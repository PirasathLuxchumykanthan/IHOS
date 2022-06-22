
export function JS(obj) {
    window.addEventListener("online", () => obj.invokeMethod("Hardware", 0));
    window.addEventListener("offline", () => obj.invokeMethod("Hardware", 1));
}
