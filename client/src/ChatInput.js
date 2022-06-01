import React, { useState } from "react";

const ChatInput = ({ sendMessage }) => {
  const [user, setUser] = useState("");
  const [message, setMessage] = useState("");

  const onUserUpdate = (e) => setUser(e.target.value);

  const onMessageUpdate = (e) => setMessage(e.target.value);

  const onSubmit = (e) => {
    e.preventDefault();

    const isUserProvided = user && user !== "";
    const isMessageProvided = message && message !== "";

    if (isUserProvided && isMessageProvided) {
      sendMessage(user, message);
    } else {
      alert("Please insert an user and a message.");
    }
  };

  return (
    <form onSubmit={onSubmit}>
      <label>User:</label>
      <br />
      <input
        type="text"
        id="user"
        name="user"
        value={user}
        onChange={onUserUpdate}
      />
      <br />
      <label htmlFor="message">Message:</label>
      <br />
      <input
        type="text"
        id="message"
        name="message"
        value={message}
        onChange={onMessageUpdate}
      />
      <br />
      <br />
      <button>Submit</button>
    </form>
  );
};

export default ChatInput;
