



$(function () {

    var ajaxFormSubmit = function () {
        var $form = $(this);

        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-yon-target"));
            var $newHtml = $(data);
            $target.replaceWith($newHtml);
            $newHtml.effect("highlight");
        });

        return false;

    };


    // automatically submit when title has been selected
    var submitAutocompleteForm = function  (event,ui){
        
        var $input =$(this);
        $input.val(ui.item.label);

        var $form = $input.parents("form:first");
        $form.submit();
    };


    //auto complete suggestion when title is typed
    var createAutocomplete = function () {
        var $input = $(this);

        var options = {
            source: $input.attr("data-yon-autocomplete"),
            select: submitAutocompleteForm
        };

        $input.autocomplete(options);
    };


    var getPage = function () {
        var $a = $(this);

        var options = {
            url: $a.attr("href"),
            data: $("form").serialize(),
            type: "get"
        };

        $.ajax(options).done(function (data) {
            var target = $a.parents("div.pagedList").attr("data-yon-target");
            $(target).replaceWith(data);
        });
        return false;


    };


    $("form[data-yon-ajax='true']").submit(ajaxFormSubmit);
    $("input[data-yon-autocomplete]").each(createAutocomplete);


    $(".body-content").on("click", ".pagedList a", getPage);
});