import { Component, Fragment } from 'react';
import {
    Link
} from 'react-router-dom';



export default class EditUserDetails extends Component{
    state = {
        user: { userName: "", id: "", email: ""},
        updateUserDetailsModel: { userName: "", email: "", password: "", confirmPassword: "" },
        msgIsError: false,
        msg: ""
    }
    loadDataFromServer = () => {
        let t = this;
        $.get("api/user/me", function(r){ t.setState({user: r, updateUserDetailsModel: {userName: r.userName, email: r.email, ...t.state.updateUserDetailsModel}})})
    }
    componentDidMount = () => {
        this.loadDataFromServer();
    }
    changeUserDetails = () => { 
        
        this.setState({msgIsError: false, msg: ""})
        let updateUserModel = this.state.updateUserDetailsModel;
        let t = this;

        if(updateUserModel.password && updateUserModel.password !== updateUserModel.confirmPassword){
            this.setState({msgIsError: true, msg: "Passwords do not match"})
        }
    
        $.ajax({      
            url: `api/user/${this.state.user.id}`,
            type: "PUT",
            data: JSON.stringify(updateUserModel),
            Accept: "application/json",
            contentType: "application/json", 
            dataType: "json",
            success: function(res) {
                t.setState({msgIsError: false, msg: "Details updated!"})
            },
            error: function (jqXHR, textStatus, errorThrown) {
                t.setState({msgIsError: true, msg: jqXHR.responseText})
            }
        });
    }
    stateMethod = (newDetail) => {
        this.setState({updateUserDetailsModel: {...this.state.updateUserDetailsModel, ...newDetail}})
    }
     render() {
            return (
                <div>
                    <h4><b>UserDetails:</b></h4>
                    <AddRoles user={this.state.user} roles={["Admin", "User"]}/>
                    <Link className="btn btn-primary" to="/userpage">Back</Link>
                   {this.state.msgIsError ? <p className="text-danger">{this.state.msg}</p> : <p className="text-success">{this.state.msg}</p> }
                   <UserForm user={this.state.user} updateUserModel={this.state.updateUserDetailsModel} stateMethod={this.stateMethod} updateUserMethod={this.changeUserDetails}/> 
                </div>
            )
        }
    }

function EditUserForm({user, updateUserModel, stateMethod, updateUserMethod}){
    return (
        <form className="form" onSubmit={e => {e.preventDefault(); updateUserMethod()}}>
              <div className="form-group">
                    <label htmlFor="username-input">Username</label>
                    <input className="form-control" placeholder={user.userName} value={updateUserModel.userName} type="text" id="username-input" onChange={e => stateMethod({ userName: e.target.value})}/>
                </div>
                <div className="form-group">
                    <label htmlFor="email-input">Email</label>
                    <input className="form-control"  placeholder={user.email} value={updateUserModel.email} type="email" id="email-input" onChange={e => stateMethod({ email: e.target.value})}/>
                </div>
                <div className="form-group">
                    <label htmlFor="password-input">New password:</label>
                    <input className="form-control" value={updateUserModel.password} type="password" id="password-input" onChange={e => stateMethod({ password: e.target.value})}/>
                </div>
                <div className="form-group">
                    <label htmlFor="confirm-password-input">Confirm new password:</label>
                    <input className="form-control"  value={updateUserModel.confirmPassword} type="password" id="confirm-password-input" onChange={e => stateMethod({ confirmPassword: e.target.value})}/>
                </div>
                <button className="btn btn-primary" type="submit">Edit</button>
        </form>
    )
}    