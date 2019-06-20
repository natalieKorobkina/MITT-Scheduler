

$(function () {
    $('#startdatepicker').datetimepicker({
        date: new Date(),
        format: 'DD/MM/YYYY',
    });
});

$(function () {
    $('#enddatepicker').datetimepicker({
        date: new Date(),
        format: 'DD/MM/YYYY',
    });
});
$(function () {
    $('#starttimepicker').datetimepicker({
        format: 'LT',
    });
});
$(function () {
    $('#endtimepicker').datetimepicker({
        format: 'LT',
    });
});