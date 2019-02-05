let root = document.getElementById("root")


class Textout extends React.Component {


    state = {value: '' }

    handleChange = (event) => {
        this.setState({ value: event.target.value });
    }

    render() {
        return (
            <div>
                <input value={this.state.value} onChange={this.handleChange} /><br />
                <input value={this.state.value} onChange={this.handleChange} /><br />
                <input value={this.state.value} onChange={this.handleChange} /><br />
                <input value={this.state.value} onChange={this.handleChange} /><br />
            </div>
        )
    }
}

ReactDOM.render( <Textout />, root);