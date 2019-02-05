let root = document.getElementById("root")

//class Emails extends React.Component {



//    render() {
//        return (
//            <div className="Emails">
//                <div>
//                    <form>
//                        <label>First Name</label>
//                        <input type="text" id="fname" name="förnamn" placeholder="Your name.." />
//                        <label>Last Name</label>
//                        <input type="text" id="lname" name="lastname" placeholder="Your last name.." />
//                        <label>Email</label>
//                        <input type="email" id="email" name="email" placeholder="Your email" />
//                        <input type="submit" value="Submit" />
//                    </form>
//                </div>
//            </div>
//        );
//    }

//}
//ReactDOM.render(<Emails />, root);




class TextBox extends React.Component {

   
    state = { value: '' }
   



    handleChange = (event) => {
        {
            this.setState({ value: event.target.value });


            let writtenInInput = event.target.value;

            var x = new RegExp(this.props.validera);
            let trueOrFalse = x.test(writtenInInput)


            if (/\b[A - Z0 -9._ % +-] +@[A - Z0 - 9. -]+\.[A - Z]{ 2,} \b/.test(event.target.value)) {
                this.setState({ backgroundColor: 'green'})
            }
            else {
                this.setState({ backgroundColor: 'red' })
            }
        }

        

    }

   
    render() {
        return (
            <div className="textWrap">
                <label>{this.props.lejbel}</label>
                <input style={{ backgroundColor: this.state.backgroundColor}}value={this.state.value} onChange={this.handleChange} />
            </div>
        )
    }
}

class App extends React.Component {
    render() {
        return (
            <div>
                <TextBox lejbel="Förnamn" />
                <TextBox lejbel="Efternamn" validera="son$" />
                <TextBox lejbel="Email" validera="\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b" ignoreracasing="true" />
            </div>
        )
    }
}
ReactDOM.render(<App/>, root)