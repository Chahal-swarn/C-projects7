<h2>All Quotes</h2>
<table>
    <thead>
        <tr>
            <th>FirstName</th>
            <th>LastName</th>
            <th>Email></th>
            <th>Quotes</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var quote in Model)
        {
            <tr>
                <td>@Quote.FirstName</td>
                <td>@Quote.LastName</td>
                <td>@Quote.Email</td>
                <td>@Quote.Quote</td>
            </tr>

        }
    </tbody>
</table>

