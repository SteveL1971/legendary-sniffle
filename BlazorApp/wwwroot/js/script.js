fetch("https://localhost:44367/api/SubCategories").then(res => res.json()).then(data => {
    for (let option of data)
        document.getElementById("category").innerHTML += `<option value="${option.id}">${option.name}</option>`
})
