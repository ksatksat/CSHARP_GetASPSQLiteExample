document.addEventListener("DOMContentLoaded", () => {
    const button = document.getElementById("get-btn");
    const result = document.getElementById("result");

    button.addEventListener("click", async () => {
        button.disabled = true;
        result.classList.remove("error");
        result.textContent = "Loading...";

        try {
            // Simple HTTP GET request to the MVC controller
            const response = await fetch("/message", { method: "GET" });
            if (!response.ok) throw new Error(`HTTP ${response.status}`);

            const data = await response.json();
            result.textContent = `Message from database: "${data.text}"`;
        } catch (err) {
            result.classList.add("error");
            result.textContent = `Request failed: ${err.message}`;
        } finally {
            button.disabled = false;
        }
    });
});
