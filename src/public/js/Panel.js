var BoxSearch = document.getElementById("Search")


//BoxSearch.addEventListener("keyup", SearchTargets());

function SearchTargets() {

    var Targets = document.getElementsByName("Target");
    filter = BoxSearch.value.toUpperCase();

    for (let TargetIndex = 0; TargetIndex < Targets.length; TargetIndex++) {
        const aula = Targets[TargetIndex].getElementsByTagName("h4")[0].textContent.toUpperCase();

        if (aula.indexOf(filter) >= 0)
            Targets[TargetIndex].style.display = "";
        else
            Targets[TargetIndex].style.display = "none";

        if (filter === "")
            Targets[TargetIndex].style.display = "";
    }
}

