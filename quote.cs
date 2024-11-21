<form asp-action="CreateQuote" method="post">
    <div>
        <label for="FirstName">FirstName</label>
        <input type="text" id="FirstName" name="FirstName" value="@Modal.FirstName" required />
    </div>
    <div>
        <label for="LastName">LastName</label>
        <input type="text" id="LastName" name="LastName" value="@Modal.lastName" required />
    </div>
    <div>
    <label for="Email">Email</label>
        <input type="text" id="Email" name="Email" value="@Modal.Email" required />
        </div>
        <div>
        <label for="IsFullCoverage">FullCoverage</label>
        <input type="checkbox" id="IsFullCoverage" name="IsFullCoverage" checked="@Modal.IsFullCoverage" required />
        </div>
        <button type="submit">Get Quote</button>
        </form>

