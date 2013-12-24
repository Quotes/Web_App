
// talk to people how to implement a dropdown whose values are populated on demand
$(function () {
    $("#dropdownloader").mouseenter(function (e) {
        if ($("#dropdownloader").attr("data-update") == "false") {
            e.preventDefault();
            $.post("/Quotes/GetProjects", null, function (data) {
                var selected = $("#projects :selected").val();
                $("#projects").empty();
                $("#projects").append("<option>Select Project</option>");
                $.each(data, function(i, option) {
                    $("#projects").append("<option>" + option + "</option>");
                });
                $("#projects").val(selected);
                $("#dropdownloader").attr('data-update', "true");
            });
        }
    });

    // to udpate the Quotes display in UI
    $("#projects").change(function (e) {
        $.post("/Quotes/GetQuotes", $("#projects :selected").val(), function (data) {
            var json = $.parseJSON(data);
            // TODO: have to get scroll bar for the table.
//            var strinnerhtml = "";
            var strinnerhtml = "<table style='width:100%'>";
            $.each(json.quotes,function (key,val) {
                  strinnerhtml = strinnerhtml + "<tr><td>" + val.quote + "&nbsp-&nbsp" + val.quoted_by + "</td></tr>";
//                strinnerhtml = strinnerhtml + "<div>" + val.quote + "</div>";
            });
            strinnerhtml = strinnerhtml + "</table>";
            $("#contentofquote").html(strinnerhtml);
        });
        $("#dropdownloader").attr('data-update', "false");
    });
});

function clearAddQuoteForm() {
    $('#form0').find("input, textarea").each(function() {
        $(this).val("");
    });
    $('#form0').find("input[type='submit']").val("Add Quote");
}

function completed(data) {
    $("#result").empty();
    if (data == false) {
        $("#result").append("<div><div style='float:left'><strong class='text'>Failed to Add Quote.</strong></div><div class='text' style='float:right' onclick='hide()'> hide</div></div>");
    } else {
        $("#result").append("<div style='color=black'>Quote Added.</div><div onclick='hide()'> hide</div>");
    }
}

function hide() {
    $("#result").empty();
}



        
        
       