import { yupResolver } from "@hookform/resolvers/yup";
import { useForm } from "react-hook-form";
import { useHistory } from "react-router-dom";
import {
  Button,
  Card,
  CardBody,
  Col,
  Form,
  FormGroup,
  InputGroup,
  Row,
} from "reactstrap";
import * as yup from "yup";
import authApi from "../../api/authApi.js";

const Login = () => {
  let history = useHistory();

  const schema = yup.object().shape({
    Username: yup.string().required(),
    Password: yup.string().required(),
  });
  const {
    register,
    handleSubmit,
    formState: { errors },
    setError,
  } = useForm({
    resolver: yupResolver(schema),
    defaultValues: {
      Username: "",
      Password: "",
      RememberMe: false,
    },
  });

  const onSubmit = async (content) => {
    var isSuccess = await authApi.loginAsync(content);
    if (isSuccess === "incorrect") {
      setError("Username", {
        type: "manual",
        message: "Username or password is incorrect",
      });
    } else if (isSuccess === false) {
      setError("Username", {
        type: "manual",
        message: "Use don't have admin permit",
      });
    } else if (isSuccess === true) {
      history.push("/admin/index");
    }
  };
  return (
    <>
      <Col lg="5" md="7">
        <Card className="bg-secondary shadow border-0">
          <CardBody className="px-lg-5">
            <div className="text-center text-muted mt-2 mb-4">
              <h2>
                Login to <br />
                Geek's Bakery Admin
              </h2>
            </div>
            <Form onSubmit={handleSubmit(onSubmit)} role="form">
              <FormGroup className="mb-3">
                <InputGroup className="input-group-alternative">
                  <input
                    className="form-control"
                    placeholder="Username"
                    type="text"
                    {...register("Username")}
                  />
                </InputGroup>
                <div
                  style={{ fontSize: 13 }}
                  className="text-danger fw-light mx-2 mt-2"
                >
                  {errors.Username?.message}
                </div>
              </FormGroup>
              <FormGroup>
                <InputGroup className="input-group-alternative">
                  <input
                    className="form-control"
                    placeholder="Password"
                    type="password"
                    name="password"
                    {...register("Password")}
                  />
                </InputGroup>
                <div
                  style={{ fontSize: 13 }}
                  className="text-danger fw-light mx-2 mt-2"
                >
                  {errors.Password?.message}
                </div>
              </FormGroup>
              <div className="custom-control custom-control-alternative custom-checkbox">
                <input
                  className="custom-control-input"
                  id=" customCheckLogin"
                  type="checkbox"
                  {...register("RememberMe")}
                />
                <label
                  className="custom-control-label"
                  htmlFor=" customCheckLogin"
                >
                  <span className="text-muted">Remember me</span>
                </label>
              </div>
              <div className="text-center">
                <Button className="mt-4 mb-3" color="primary" type="submit">
                  Sign in
                </Button>
              </div>
            </Form>
          </CardBody>
        </Card>
        <Row className="mt-3">
          <Col className="text-right">
            <a
              className="text-light"
              href="#pablo"
              onClick={(e) => e.preventDefault()}
            >
              <small>Do not have account? Contact administrator</small>
            </a>
          </Col>
        </Row>
      </Col>
    </>
  );
};

export default Login;
